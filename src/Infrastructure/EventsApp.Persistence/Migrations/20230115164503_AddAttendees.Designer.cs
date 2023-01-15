﻿// <auto-generated />
using System;
using EventsApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    [DbContext(typeof(EventsAppDbContext))]
    [Migration("20230115164503_AddAttendees")]
    partial class AddAttendees
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

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
                            Date = new DateTime(2022, 11, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6561),
                            Description = "Activity 2 months ago",
                            IsCancelled = false,
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2022, 12, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6667),
                            Description = "Activity 1 month ago",
                            IsCancelled = false,
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2023, 2, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6694),
                            Description = "Activity 1 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 3, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6712),
                            Description = "Activity 2 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 4, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6727),
                            Description = "Activity 3 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 5, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6745),
                            Description = "Activity 4 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 6, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6760),
                            Description = "Activity 5 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 7, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6776),
                            Description = "Activity 6 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2023, 8, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6794),
                            Description = "Activity 2 months ago",
                            IsCancelled = false,
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2023, 9, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6810),
                            Description = "Activity 8 months in future",
                            IsCancelled = false,
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

                    b.HasData(
                        new
                        {
                            ActivityAttendeeId = new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                            Email = "bob@test.com",
                            IsHost = true,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"),
                            ActivityId = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "bob@test.com",
                            IsHost = true,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"),
                            ActivityId = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("c0f0642b-f235-4c65-8ca6-7fdde6a7518c"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Email = "tom@test.com",
                            IsHost = true,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("582ce36c-77a7-4689-9b78-e2419e78316b"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Email = "tom@test.com",
                            IsHost = true,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("41232c7a-1714-4025-bd01-2de96444c18f"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"),
                            ActivityId = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Email = "bob@test.com",
                            IsHost = true,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"),
                            ActivityId = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Email = "tom@test.com",
                            IsHost = false,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"),
                            ActivityId = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = true,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("13665690-c91a-4382-8615-863dc196a256"),
                            ActivityId = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Email = "bob@test.com",
                            IsHost = false,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = true,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"),
                            ActivityId = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Email = "bob@test.com",
                            IsHost = true,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"),
                            ActivityId = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"),
                            ActivityId = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "tom@test.com",
                            IsHost = true,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"),
                            ActivityId = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"),
                            ActivityId = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "bob@test.com",
                            IsHost = true,
                            UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("72751074-d753-4e58-9c78-89e764cbdce4"),
                            ActivityId = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Email = "tom@test.com",
                            IsHost = false,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Email = "tom@test.com",
                            IsHost = true,
                            UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Email = "jane@test.com",
                            IsHost = false,
                            UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                            UserName = "jane"
                        });
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
