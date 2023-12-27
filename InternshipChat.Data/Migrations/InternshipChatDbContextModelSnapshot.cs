﻿// <auto-generated />
using InternshipChat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InternshipChat.Data.Migrations
{
    [DbContext(typeof(InternshipChatDbContext))]
    partial class InternshipChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("Canals", (string)null);
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

                    b.ToTable("Messages", (string)null);
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

                    b.Property<string>("Surename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("InternshipChat.Data.Entities.Models.UserCanal", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("CanalId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "CanalId");

                    b.HasIndex("CanalId");

                    b.ToTable("UserCanals", (string)null);
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