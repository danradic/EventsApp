namespace EventsApp.Application.Errors
{
    /// <summary>
    /// Error types.
    /// </summary>
    public enum ErrorType
    {
        Failure,
        Unexpected,
        Validation,
        Conflict,
        NotFound,
        Unauthorized,
        Registration
    }
}