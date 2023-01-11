using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsApp.Persistence.Configurations
{
    public class ActivityAttendeeConfiguration : IEntityTypeConfiguration<ActivityAttendee>
    {
        public void Configure(EntityTypeBuilder<ActivityAttendee> builder)
        {
        }
    }
}