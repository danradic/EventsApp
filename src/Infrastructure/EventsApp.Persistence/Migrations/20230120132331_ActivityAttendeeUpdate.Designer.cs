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
    [Migration("20230120132331_ActivityAttendeeUpdate")]
    partial class ActivityAttendeeUpdate
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
                            Date = new DateTime(2022, 11, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8724),
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
                            Date = new DateTime(2022, 12, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8912),
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
                            Date = new DateTime(2023, 2, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8929),
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
                            Date = new DateTime(2023, 3, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8946),
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
                            Date = new DateTime(2023, 4, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8961),
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
                            Date = new DateTime(2023, 5, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8979),
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
                            Date = new DateTime(2023, 6, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8994),
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
                            Date = new DateTime(2023, 7, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9010),
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
                            Date = new DateTime(2023, 8, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9025),
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
                            Date = new DateTime(2023, 9, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9043),
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
                            ActivityAttendeeId = new Guid("c5b2be3b-627e-47cd-b893-18de572aaa71"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = true,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("90c71ad5-cc49-4b3a-bf58-28c7e776d61f"),
                            ActivityId = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = true,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798"),
                            ActivityId = new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = false,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("23183bdc-a1db-45db-824f-179cf8a8c331"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg",
                            IsHost = true,
                            UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("87a262c6-c597-4c2d-97fe-732a2737e406"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = false,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c"),
                            ActivityId = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = true,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("525b8837-3935-4900-8aab-09f5dce68b4a"),
                            ActivityId = new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                            Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg",
                            IsHost = false,
                            UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("4ebe321f-f48b-4574-9098-1453fdde0331"),
                            ActivityId = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = true,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("16c4764a-a85c-4d31-98e7-b22a83915cff"),
                            ActivityId = new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = false,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("d0d1684b-861d-4700-adf1-ec457b50d7e6"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = true,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("bdc6adab-a35a-4a3a-bc4b-63482e724f99"),
                            ActivityId = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = true,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("f185ce01-3ba6-455a-b5c7-3dcb7b08fcad"),
                            ActivityId = new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = false,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd"),
                            ActivityId = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg",
                            IsHost = true,
                            UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("7f876625-4407-4439-916a-203bb144e5a3"),
                            ActivityId = new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = false,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("30156295-b85c-429f-8924-f019a37db3d3"),
                            ActivityId = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg",
                            IsHost = true,
                            UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                            UserName = "bob"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("b9d2ed76-e6c1-4d56-80e4-95e055f02f49"),
                            ActivityId = new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg",
                            IsHost = false,
                            UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("38b42910-ed98-424e-97ce-2887ae1ef97d"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg",
                            IsHost = true,
                            UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                            UserName = "tom"
                        },
                        new
                        {
                            ActivityAttendeeId = new Guid("6137ddf4-523f-4392-a9cd-d947ac6cdf5a"),
                            ActivityId = new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                            Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            Image = "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg",
                            IsHost = false,
                            UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                            UserName = "jane"
                        });
                });

            modelBuilder.Entity("EventsApp.Domain.Entities.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
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