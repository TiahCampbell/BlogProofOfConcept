using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Fitness",
                    Image = "Images/Fitness.jpg"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Nutrition",
                    Image = "Images/Nutrition.jpg"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Pets",
                    Image = "Images/Pets.jpg"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Family",
                    Image = "Images/Family.jpg"
                }
                );

            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    Title = "Strong",
                    Body = "Working out by learning a new Strong class to teach! It's taking time to get my strength and stamina back after baby, but I can do full push ups again! Little wins...getting stronger everyday!",
                    Author = "Teacup",
                    Image = "Images/Strong.jpg",
                    PublishDate = "3/2/2021 05:35:21 PM",
                    CategoryId = 1,
                    ColorId = 1
                },
                new Content()
                {
                    Id = 2,
                    Title = "Meal Prep",
                    Body = "Made some quinoa with tofu, mushrooms, tomato, red bell peppers, and broccoli for meal prep this week. Topped it with some avacado for those healthy fats!",
                    Author = "Teacup",
                    Image = "Images/MealPrep.jpg",
                    PublishDate = "3/3/2021 04:22:32 PM",
                    CategoryId = 2,
                    ColorId = 2
                },
                new Content()
                {
                    Id = 3,
                    Title = "Thief",
                    Body = "So my dog is obsessed with our babies new toy. Keep in mind Washburne got three new toys only a week ago for his 6th birthday. This week I bought a new set of stacking teething rings for Miles and he has already stolen and destroyed two of the rings. Upon seeing how distraught my husband and I were when he destroyed the first two, he has decided that he should not chew them up. This has not stopped him from periodically stealing the smallest blue teething ring and hiding it around the house for himself.",
                    Author = "Teacup",
                    Image = "Images/Thief.jpg",
                    PublishDate = "3/5/2021 06:12:02 PM",
                    CategoryId = 3,
                    ColorId = 5
                },
                new Content()
                {
                    Id = 4,
                    Title = "Crawling",
                    Body = "Miles is on the move. We have been frantically baby proofing the house as our 6 month old baby has already learned to crawl and pull himself up on furniture. We spent a ridiculous amount of money on two retractable mesh baby gates on Amazon this week to rig up a way to protect the entertainment center and two xbox series x's from his little grabbing hands. Pardon our dust.",
                    Author = "Teacup",
                    Image = "Images/Crawling.jpg",
                    PublishDate = "3/4/2021 08:42:55 PM",
                    CategoryId = 4,
                    ColorId = 4
                },
                new Content()
                {
                    Id = 5,
                    Title = "Spartan",
                    Author = "Teacup",
                    Body = "It's been a few years since my husband and I ran the Spartan Sprint in 2018 with my students. It was a blast and an experience to remember. Climbing, running, mud pits, and coaching my students through that fear of heights! Even though we got pulled off the course for a freak lightning storm, we stuck it out and got back out there after the storm cleared. Jumping that fire was an awesome moment! Giving my body the time to heal and working to get back to where I was before baby. But my goal is to run another one in 2022. I can't wait!",
                    Image = "Images/Spartan2.jpg",
                    PublishDate = "3/6/2021 06:11:22 PM",
                    CategoryId = 1,
                    ColorId = 6
                },
                new Content()
                {
                    Id = 6,
                    Title = "Mango",
                    Body = "Miles is starting to eat solid foods! He enjoys blueberries, broccoli, and tofu so far. Today he tried mango and it was an instant hit!",
                    Author = "Teacup",
                    Image = "Images/Mango.jpg",
                    PublishDate = "3/7/2021 11:02:43 PM",
                    CategoryId = 2,
                    ColorId = 3
                },
                new Content()
                {
                    Id = 7,
                    Title = "Guitar",
                    Body = "Washburne is six years old now. Over the years he has learned to accept Nate playing guitar. Don't let that fool you though, this drama puppy used to lay there and cry anytime Nate even opened his guitar case as a wee pup.",
                    Author = "Teacup",
                    Image = "Images/Guitar.jpg",
                    PublishDate = "3/9/2021 10:38:41 PM",
                    CategoryId = 3,
                    ColorId = 7
                },
                new Content()
                {
                    Id = 9,
                    Title = "Backyard",
                    Body = "Miles went on his first adventure in the backyard today! He got to play with leaves, zoom down his little tykes slide, and toddle after his doggo around the yard! Excited for more days like this!",
                    Author = "Teacup",
                    Image = "Images/Backyard.jpg",
                    PublishDate = "3/8/2021 10:21:48 PM",
                    CategoryId = 4,
                    ColorId = 1
                }
                );
            modelBuilder.Entity<Color>().HasData(
                new Color()
                {
                    Id = 1,
                    Name = "Blue.css",
                },
                new Color()
                {
                    Id = 2,
                    Name = "Green.css",
                },
                new Color()
                {
                    Id = 3,
                    Name = "Yellow.css",
                },
                new Color()
                {
                    Id = 4,
                    Name = "Orange.css",
                },
                new Color()
                {
                    Id = 5,
                    Name = "Red.css",
                },
                new Color()
                {
                    Id = 6,
                    Name = "Pink.css",
                },
                new Color()
                {
                    Id = 7,
                    Name = "Purple.css",
                }
                );

        }
    }
}
