﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "Images/Fitness.jpg",
                            Name = "Fitness"
                        },
                        new
                        {
                            Id = 2,
                            Image = "Images/Nutrition.jpg",
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 3,
                            Image = "Images/Pets.jpg",
                            Name = "Pets"
                        },
                        new
                        {
                            Id = 4,
                            Image = "Images/Family.jpg",
                            Name = "Family"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Blue.css"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Green.css"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Yellow.css"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Orange.css"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Red.css"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Pink.css"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Purple.css"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Teacup",
                            Body = "Working out by learning a new Strong class to teach! It's taking time to get my strength and stamina back after baby, but I can do full push ups again! Little wins...getting stronger everyday!",
                            CategoryId = 1,
                            ColorId = 1,
                            Image = "Images/Strong.jpg",
                            PublishDate = "03/02/21",
                            Title = "Strong"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Teacup",
                            Body = "Made lentil tacos for dinner tonight. I grabbed a new recipe offline I wanted to try. The recipe used veggie broth and finished it off with mixing in salsa at the end. Definitely yummy, would eat again.",
                            CategoryId = 2,
                            ColorId = 1,
                            Image = "Images/Nutrition.jpg",
                            PublishDate = "03/03/21",
                            Title = "Lentil Tacos"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Teacup",
                            Body = "So my dog is obsessed with our babies new toy. Keep in mind Washburne got three new toys only a week ago for his 6th birthday. This week I bought a new set of stacking teething rings for Miles and he has already stolen and destroyed two of the rings. Upon seeing how distraught my husband and I were when he destroyed the first two, he has decided that he should not chew them up. This has not stopped him from periodically stealing the smallest blue teething ring and hiding it around the house for himself.",
                            CategoryId = 3,
                            ColorId = 1,
                            Image = "Images/Thief.jpg",
                            PublishDate = "03/05/21",
                            Title = "Thief"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Teacup",
                            Body = "Miles is on the move. We have been frantically baby proofing the house as our 6 month old baby has already learned to crawl and pull himself up on furniture. We spent a ridiculous amount of money on two retractable mesh baby gates on Amazon this week to rig up a way to protect the entertainment center and two xbox series x's from his little grabbing hands. Pardon our dust.",
                            CategoryId = 4,
                            ColorId = 1,
                            Image = "Images/Crawling.jpg",
                            PublishDate = "03/04/21",
                            Title = "Crawling"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blog_template_practice.Models.Color", "color")
                        .WithMany("Contents")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
