﻿// <auto-generated />
using EF_Indicies_FluentAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Indicies_FluentAPI.Migrations
{
    [DbContext(typeof(CharactersDbContext))]
    [Migration("20210218074125_Author Index Added")]
    partial class AuthorIndexAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AuthorId");

                    b.HasIndex("AuthorName", "AuthorSurname")
                        .IsUnique()
                        .HasFilter("[AuthorName] IS NOT NULL AND [AuthorSurname] IS NOT NULL");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Isaak",
                            AuthorSurname = "Azimov"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Johr Ronald Ruel",
                            AuthorSurname = "Talkien"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Dan",
                            AuthorSurname = "Simmons"
                        });
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            FirstName = "Harry",
                            Gender = true,
                            LastName = "Seldon",
                            StoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 2700,
                            FirstName = "Arven",
                            Gender = false,
                            LastName = "Undomiel",
                            StoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 14,
                            FirstName = "Finn",
                            Gender = true,
                            LastName = "Mertens",
                            StoryId = 3
                        });
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "",
                            Name = "Foundation"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "",
                            Name = "LOTR"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "",
                            Name = "Hyperion"
                        });
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Character", b =>
                {
                    b.HasOne("EF_Indicies_FluentAPI.Models.Story", "Story")
                        .WithMany("Characters")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Story", b =>
                {
                    b.HasOne("EF_Indicies_FluentAPI.Models.Author", "Author")
                        .WithMany("Stories")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Author", b =>
                {
                    b.Navigation("Stories");
                });

            modelBuilder.Entity("EF_Indicies_FluentAPI.Models.Story", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
