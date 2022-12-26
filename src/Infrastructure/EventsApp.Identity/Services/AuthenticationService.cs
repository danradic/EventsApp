using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EventsApp.Application.Models.Authentication;
using EventsApp.Application.Contracts.Identity;
using EventsApp.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using EventsApp.Application.Responses;
using EventsApp.Application.Errors;
using Microsoft.AspNetCore.Http;

namespace EventsApp.Identity.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;
        private IHttpContextAccessor _httpContextAccessor;

        public AuthenticationService(UserManager<ApplicationUser> userManager,
            IOptions<JwtSettings> jwtSettings,
            SignInManager<ApplicationUser> signInManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request)
        {
            AuthenticationResponse response = new();

            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                return Result<AuthenticationResponse>.Failure(errorType: ErrorType.Unauthorized, message: $"User with email '{request.Email}' not found.");

            var signInResult = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!signInResult.Succeeded)
                return Result<AuthenticationResponse>.Failure(errorType: ErrorType.Unauthorized, message: $"Credentials for '{request.Email}' aren't valid.");

            JwtSecurityToken jwtSecurityToken = await GenerateToken(user);
            response.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.Id = user.Id;
            response.Email = user.Email;
            response.UserName = user.UserName;
            response.Image = null;
            response.DisplayName = user.DisplayName;

            return Result<AuthenticationResponse>.Success(response);
        }

        public async Task<Result<RegistrationResponse>> RegisterAsync(RegistrationRequest request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.UserName);

            if (existingUser != null)
                return Result<RegistrationResponse>.Failure(errorType: ErrorType.Conflict, message: $"Username '{request.UserName}' already exists.");

            existingUser = await _userManager.FindByEmailAsync(request.Email);

            if (existingUser != null)
                return Result<RegistrationResponse>.Failure(errorType: ErrorType.Conflict, message: $"Email '{request.UserName}' already exists.");

            var user = new ApplicationUser
            {
                Email = request.Email,
                DisplayName = request.DisplayName,
                UserName = request.UserName,
                Bio = request.Bio,
                EmailConfirmed = true
            };

            var identityResult = await _userManager.CreateAsync(user, request.Password);

            if (!identityResult.Succeeded)
            {
                List<Error> errors = new();

                foreach (var identityError in identityResult.Errors.ToList())
                {
                    Error error = new() 
                    {
                        ErrorType = ErrorType.Validation,
                        ErrorMessage = identityError.Description,
                        ErrorCode = identityError.Code
                    };
                    errors.Add(error);
                }
                return Result<RegistrationResponse>.Failure(errors: errors);
            }

            return Result<RegistrationResponse>.Success(new RegistrationResponse {UserId = user.Id});
        }

        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<Result<AuthenticationResponse>> GetCurrentUser()
        {
            var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
            var appUser = await _userManager.FindByEmailAsync(claimsPrincipal.FindFirstValue(ClaimTypes.Email));

            if(appUser == null)
                return Result<AuthenticationResponse>.Failure(errorType: ErrorType.NotFound, message: "User not found.");

            var jwtSecurityToken = await GenerateToken(appUser);
            var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            var user = new AuthenticationResponse
            {
                DisplayName = appUser.DisplayName,
                Image = null,
                Token = token,
                UserName = appUser.UserName
            };

            return Result<AuthenticationResponse>.Success(user);
        }
    }
}