using AutoMapper;
using EventsApp.Application.Features.Activities.Commands.CreateActivity;
using EventsApp.Application.Features.Activities.Commands.UpdateActivity;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Application.Features.Activities.Queries.GetActivityDetail;
using EventsApp.Domain.Entities;

namespace EventsApp.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, ActivityListViewModel>().ReverseMap();
            CreateMap<Activity, ActivityDetailViewModel>().ReverseMap();
            CreateMap<Activity, CreateActivityCommand>().ReverseMap();
            CreateMap<Activity, UpdateActivityCommand>().ReverseMap();
            CreateMap<Activity, ActivityViewModel>().ReverseMap();
            CreateMap<Activity, ActivityDetailViewModel>().ReverseMap();
        }
    }
}