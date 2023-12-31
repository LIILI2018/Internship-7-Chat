﻿// <auto-generated />
using InternshipChat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InternshipChat.Data.Migrations
{
    [DbContext(typeof(InternshipChatDbContext))]
    [Migration("20231231150041_Change UserCanal")]
    partial class ChangeUserCanal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.Canal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CanalType")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Canals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanalType = 0,
                            Name = "Ivan-Toni"
                        },
                        new
                        {
                            Id = 2,
                            CanalType = 1,
                            Name = "Kanal za admine"
                        },
                        new
                        {
                            Id = 3,
                            CanalType = 1,
                            Name = "Kanal za sve"
                        },
                        new
                        {
                            Id = 4,
                            CanalType = 0,
                            Name = "Dino-Zoran"
                        });
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CanalId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CanalId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanalId = 3,
                            Content = "Pokemoni",
                            Title = "Dadada",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CanalId = 1,
                            Content = "Jabuka je crvena",
                            Title = "1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CanalId = 2,
                            Content = "Lorem ipsum dolor sit amet",
                            Title = "2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CanalId = 2,
                            Content = "kako si",
                            Title = "3",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CanalId = 2,
                            Content = "Si akako",
                            Title = "4",
                            UserId = 4
                        },
                        new
                        {
                            Id = 6,
                            CanalId = 2,
                            Content = "A tout le monde",
                            Title = "5",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            CanalId = 3,
                            Content = "A tout mes amies",
                            Title = "6",
                            UserId = 2
                        },
                        new
                        {
                            Id = 8,
                            CanalId = 3,
                            Content = "Je vus aime ",
                            Title = "7",
                            UserId = 5
                        },
                        new
                        {
                            Id = 9,
                            CanalId = 3,
                            Content = "Megadeath",
                            Title = "8",
                            UserId = 3
                        },
                        new
                        {
                            Id = 10,
                            CanalId = 3,
                            Content = "Sunce siješe bijelom bojom",
                            Title = "9",
                            UserId = 6
                        },
                        new
                        {
                            Id = 11,
                            CanalId = 3,
                            Content = "si kako",
                            Title = "Kako si",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "IvanRaca@gmail.com",
                            IsAdmin = true,
                            Name = "Ivan",
                            Password = "RacaJeNajbolji",
                            Surename = "Racetin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Muzika@gmail.com",
                            IsAdmin = true,
                            Name = "Toni",
                            Password = "321123",
                            Surename = "Cetinski"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Pjesništvo1000@gmail.com",
                            IsAdmin = true,
                            Name = "Luko",
                            Password = "12345",
                            Surename = "Paljetak"
                        },
                        new
                        {
                            Id = 4,
                            Email = "RibeSuNajbolje@gmail.com",
                            IsAdmin = true,
                            Name = "Mihaela",
                            Password = "VoxPopuli123",
                            Surename = "Orah"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Korona123@gmail.com",
                            IsAdmin = false,
                            Name = "Marin",
                            Password = "0987654321234567890",
                            Surename = "Zika"
                        },
                        new
                        {
                            Id = 6,
                            Email = "BiliPivac@gmail.com",
                            IsAdmin = false,
                            Name = "Vojko",
                            Password = "EpskiHahač",
                            Surename = "V"
                        },
                        new
                        {
                            Id = 7,
                            Email = "Zoran321@gmail.com",
                            IsAdmin = false,
                            Name = "Zoran",
                            Password = "TomCruse",
                            Surename = "Tadija"
                        },
                        new
                        {
                            Id = 8,
                            Email = "ZV@gmail.com",
                            IsAdmin = false,
                            Name = "Željko",
                            Password = "Raketa123",
                            Surename = "Veliki"
                        },
                        new
                        {
                            Id = 9,
                            Email = "ZM@gmail.com",
                            IsAdmin = false,
                            Name = "Željko",
                            Password = "Vlak123",
                            Surename = "Veliki"
                        },
                        new
                        {
                            Id = 10,
                            Email = "VEDROORDEV@gmail.com",
                            IsAdmin = false,
                            Name = "Veran",
                            Password = "Šifra",
                            Surename = "Brkan"
                        },
                        new
                        {
                            Id = 11,
                            Email = "MarioDživo2@gmail.com",
                            IsAdmin = false,
                            Name = "Marin",
                            Password = "NeMaM ŠiFrU",
                            Surename = "Getaldić"
                        },
                        new
                        {
                            Id = 12,
                            Email = "DinoD.@gmail.com",
                            IsAdmin = true,
                            Name = "Dino",
                            Password = "DDDDd",
                            Surename = "Dujmović"
                        },
                        new
                        {
                            Id = 13,
                            Email = "aa",
                            IsAdmin = true,
                            Name = "Dino",
                            Password = "aa",
                            Surename = "Dujmović"
                        },
                        new
                        {
                            Id = 14,
                            Email = "aaa",
                            IsAdmin = true,
                            Name = "Dino",
                            Password = "aa",
                            Surename = "Dujmović"
                        });
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.UserCanal", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("CanalId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "CanalId");

                    b.HasIndex("CanalId");

                    b.ToTable("UserCanals");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CanalId = 1
                        },
                        new
                        {
                            UserId = 2,
                            CanalId = 1
                        },
                        new
                        {
                            UserId = 1,
                            CanalId = 2
                        },
                        new
                        {
                            UserId = 2,
                            CanalId = 2
                        },
                        new
                        {
                            UserId = 3,
                            CanalId = 2
                        },
                        new
                        {
                            UserId = 4,
                            CanalId = 2
                        },
                        new
                        {
                            UserId = 12,
                            CanalId = 2
                        },
                        new
                        {
                            UserId = 1,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 2,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 3,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 4,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 5,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 6,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 7,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 8,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 9,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 10,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 11,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 12,
                            CanalId = 3
                        },
                        new
                        {
                            UserId = 7,
                            CanalId = 4
                        },
                        new
                        {
                            UserId = 12,
                            CanalId = 4
                        });
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.Message", b =>
                {
                    b.HasOne("InternshipChat.Data.Entities.Models.Canal", "Canal")
                        .WithMany("Messages")
                        .HasForeignKey("CanalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternshipChat.Data.Entities.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.UserCanal", b =>
                {
                    b.HasOne("InternshipChat.Data.Entities.Models.Canal", "Canal")
                        .WithMany("UserCanals")
                        .HasForeignKey("CanalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternshipChat.Data.Entities.Models.User", "User")
                        .WithMany("UserCanals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.Canal", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserCanals");
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.User", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("UserCanals");
                });
#pragma warning restore 612, 618
        }
    }
}
