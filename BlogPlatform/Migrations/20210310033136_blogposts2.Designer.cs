﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20210310033136_blogposts2")]
    partial class blogposts2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            PublishDate = "3/2/21",
                            Title = "Strong"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Teacup",
                            Body = "Made some quinoa with tofu, mushrooms, tomato, red bell peppers, and broccoli for meal prep this week. Topped it with some avacado for those healthy fats!",
                            CategoryId = 2,
                            ColorId = 2,
                            Image = "Images/MealPrep.jpg",
                            PublishDate = "3/3/21",
                            Title = "Meal Prep"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Teacup",
                            Body = "So my dog is obsessed with our babies new toy. Keep in mind Washburne got three new toys only a week ago for his 6th birthday. This week I bought a new set of stacking teething rings for Miles and he has already stolen and destroyed two of the rings. Upon seeing how distraught my husband and I were when he destroyed the first two, he has decided that he should not chew them up. This has not stopped him from periodically stealing the smallest blue teething ring and hiding it around the house for himself.",
                            CategoryId = 3,
                            ColorId = 5,
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
                            ColorId = 4,
                            Image = "Images/Crawling.jpg",
                            PublishDate = "3/4/21",
                            Title = "Crawling"
                        },
                        new
                        {
                            Id = 6,
                            Body = "It's been a few years since my husband and I ran the Spartan Sprint in 2018 with my students. It was a blast and an experience to remember. Climbing, running, mud pits, and coaching my students through that fear of heights! Even though we got pulled off the course for a freak lightning storm, we stuck it out and got back out there after the storm cleared. Jumping that fire was an awesome moment! Giving my body the time to heal and working to get back to where I was before baby. But my goal is to run another one in 2022. I can't wait!",
                            CategoryId = 1,
                            ColorId = 6,
                            Image = "Images/Spartan2.jpg",
                            PublishDate = "3/6/21",
                            Title = "Spartan"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Teacup",
                            Body = "Miles is starting to eat solid foods! He enjoys blueberries, broccoli, and tofu so far. Today he tried mango and it was an instant hit!",
                            CategoryId = 2,
                            ColorId = 3,
                            Image = "Images/Mango.jpg",
                            PublishDate = "3/7/21",
                            Title = "Mango"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Teacup",
                            Body = "Washburne is six years old now. Over the years he has learned to accept Nate playing guitar. Don't let that fool you though, this drama puppy used to lay there and cry anytime Nate even opened his guitar case as a wee pup.",
                            CategoryId = 3,
                            ColorId = 7,
                            Image = "Images/Guitar.jpg",
                            PublishDate = "03/09/21",
                            Title = "Guitar"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Teacup",
                            Body = "Miles went on his first adventure in the backyard today! He got to play with leaves, zoom down his little tykes slide, and toddle after his doggo around the yard! Excited for more days like this!",
                            CategoryId = 4,
                            ColorId = 1,
                            Image = "Images/Backyard.jpg",
                            PublishDate = "3/8/21",
                            Title = "Backyard"
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