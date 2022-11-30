using AutoMapper;
using EventsApp.Application.Features.Activities.Queries.GetActivitiesList;
using EventsApp.Domain.Entities;

namespace EventsApp.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, ActivityListViewModel>().ReverseMap();
        }
    }
}