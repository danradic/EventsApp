﻿// <auto-generated />
using System;
using EventsApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    [DbContext(typeof(EventsAppDbContext))]
    partial class EventsAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventsApp.Domain.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2022, 11, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(152),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2022, 12, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(286),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2023, 2, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(318),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 3, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(343),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 4, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(366),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 5, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(400),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 6, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(456),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 7, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(481),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2023, 8, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(505),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2023, 9, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(542),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });

            modelBuilder.Entity("EventsApp.Domain.Entities.ActivityAttendee", b =>
                {
                    b.Property<Guid>("ActivityAttendeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHost")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityAttendeeId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityAttendees");
                });

            modelBuilder.Entity("EventsApp.Domain.Entities.ActivityAttendee", b =>
                {
                    b.HasOne("EventsApp.Domain.Entities.Activity", "Activity")
                        .WithMany("Attendees")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("EventsApp.Domain.Entities.Activity", b =>
                {
                    b.Navigation("Attendees");
                });
#pragma warning restore 612, 618
        }
    }
}
