using AutoMapper;
using EventsApp.Application.Errors;
using EventsApp.Application.Features.Activities.Commands.CreateActivity;
using EventsApp.Application.Features.Activities.Commands.UpdateActivity;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Application.Features.Activities.Queries.GetActivityDetail;
using EventsApp.Application.Models;
using EventsApp.Domain.Entities;
using FluentValidation.Results;

namespace EventsApp.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, ActivityListViewModel>()
                .ForMember(d => d.HostUsername, o => o.MapFrom(s => s.Attendees
                    .FirstOrDefault(x => x.IsHost).UserName))
                .ReverseMap();
            CreateMap<ActivityAttendee, User>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.UserId))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.DisplayName))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.Bio))
                .ForMember(d => d.Image, o => o.MapFrom(s => s.Image));

            CreateMap<Activity, ActivityDetailViewModel>().ReverseMap();
            CreateMap<Activity, CreateActivityCommand>().ReverseMap();
            CreateMap<Activity, UpdateActivityCommand>().ReverseMap();
            CreateMap<Activity, ActivityViewModel>().ReverseMap();
            CreateMap<Activity, ActivityDetailViewModel>().ReverseMap();
            
            CreateMap<Error, ValidationFailure>().ReverseMap();
            // CreateMap<List<Error>, List<ValidationFailure>>().ReverseMap();

        }
    }
}