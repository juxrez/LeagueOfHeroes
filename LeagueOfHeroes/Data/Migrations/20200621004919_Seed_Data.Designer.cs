﻿// <auto-generated />
using System;
using LeagueOfHeroes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueOfHeroes.Data.Migrations
{
    [DbContext(typeof(LeagueOfHeroesContext))]
    [Migration("20200621004919_Seed_Data")]
    partial class Seed_Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LeagueOfHeroes.Data.Entities.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Picture")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 45,
                            City = "Noxus",
                            Name = "Alistar",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt3b366925d2fd8fdb/5db05fa856458c6b3fc1750b/RiotX_ChampionList_alistar.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 2,
                            Age = 33,
                            City = "Bilgewater",
                            Name = "Aakali",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt80ff58fe809777ff/5db05fa8adc8656c7d24e7d6/RiotX_ChampionList_akali.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 3,
                            Age = 27,
                            City = "Piltover",
                            Name = "VI",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt3bd79abf330fc807/5db06014dc674266df3d5d56/RiotX_ChampionList_vi.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 4,
                            Age = 230,
                            City = "Bilgewater",
                            Name = "Vladimir",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt39ab5027f6fa1b81/5db0601589fb926b491ed82f/RiotX_ChampionList_vladimir.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 5,
                            Age = 88,
                            City = "Ionia",
                            Name = "Zac",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9412083c2b98b9c8/5db0601d6af83b6d7032c910/RiotX_ChampionList_zac.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 6,
                            Age = 33,
                            City = "Bilgewater",
                            Name = "Sona",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt4810827f74fc21b9/5db06003347d1c6baa57be49/RiotX_ChampionList_sona.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 7,
                            Age = 36,
                            City = "Shadow Isles",
                            Name = "Morgana",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltc81eece55f126d2d/5db05fe86af83b6d7032c904/RiotX_ChampionList_morgana.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 8,
                            Age = 1240,
                            City = "Demacia",
                            Name = "Azir",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt0e3f847946232167/5db05fa889fb926b491ed7ff/RiotX_ChampionList_azir.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 9,
                            Age = 38,
                            City = "Noxus",
                            Name = "Draven",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltc0be728e4cbb8f2a/5db05fbc89fb926b491ed80b/RiotX_ChampionList_draven.jpg?quality=90&width=100"
                        },
                        new
                        {
                            Id = 10,
                            Age = 30,
                            City = "Targon",
                            Name = "Fiora",
                            Picture = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt935dd149b2617ac8/5db05fbcdc674266df3d5d36/RiotX_ChampionList_fiora.jpg?quality=90&width=100"
                        });
                });

            modelBuilder.Entity("LeagueOfHeroes.Data.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<string>("RatingBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HeroId = 1,
                            RatingBy = "Alvaro L.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 2,
                            HeroId = 1,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 3,
                            HeroId = 1,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 4,
                            HeroId = 1,
                            RatingBy = "Tania G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 2
                        },
                        new
                        {
                            Id = 5,
                            HeroId = 2,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 6,
                            HeroId = 2,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 7,
                            HeroId = 2,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 8,
                            HeroId = 3,
                            RatingBy = "Tania G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 9,
                            HeroId = 3,
                            RatingBy = "Maria L.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 10,
                            HeroId = 3,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 11,
                            HeroId = 3,
                            RatingBy = "Alberto P.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 12,
                            HeroId = 4,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 2
                        },
                        new
                        {
                            Id = 13,
                            HeroId = 4,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 14,
                            HeroId = 4,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 15,
                            HeroId = 5,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 16,
                            HeroId = 5,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 17,
                            HeroId = 5,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 18,
                            HeroId = 5,
                            RatingBy = "Rodgrigo A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 2
                        },
                        new
                        {
                            Id = 19,
                            HeroId = 6,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 20,
                            HeroId = 6,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 21,
                            HeroId = 6,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 22,
                            HeroId = 6,
                            RatingBy = "Tania G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 23,
                            HeroId = 7,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 24,
                            HeroId = 7,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 25,
                            HeroId = 7,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 26,
                            HeroId = 8,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 27,
                            HeroId = 8,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 28,
                            HeroId = 8,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 29,
                            HeroId = 8,
                            RatingBy = "Joaquin J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 30,
                            HeroId = 9,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 3
                        },
                        new
                        {
                            Id = 31,
                            HeroId = 9,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 32,
                            HeroId = 9,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 4
                        },
                        new
                        {
                            Id = 33,
                            HeroId = 10,
                            RatingBy = "Alex J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 34,
                            HeroId = 10,
                            RatingBy = "Ramon A.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 35,
                            HeroId = 10,
                            RatingBy = "Pedro G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 36,
                            HeroId = 10,
                            RatingBy = "Tania G.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        },
                        new
                        {
                            Id = 37,
                            HeroId = 10,
                            RatingBy = "Joaquin J.",
                            RatingDate = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stars = 5
                        });
                });

            modelBuilder.Entity("LeagueOfHeroes.Data.Entities.Rating", b =>
                {
                    b.HasOne("LeagueOfHeroes.Data.Entities.Hero", "Hero")
                        .WithMany("Reviews")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
