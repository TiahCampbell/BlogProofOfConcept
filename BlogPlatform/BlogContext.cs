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
                    Name = "Fitness"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Nutrition"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Pets"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Family"
                }
                );

            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    Title = "Strong",
                    Body = "Working out by learning a new Strong class to teach! It's taking time to get my strength and stamina back after baby, but I can do full push ups again! Little wins...getting stronger everyday!",
                    Author = "Teacup",
                    PublishDate = "03/02/21",
                    CategoryId = 1
                },
                new Content()
                {
                    Id = 2,
                    Title = "Lentil Tacos",
                    Body = "Made lentil tacos for dinner tonight. I grabbed a new recipe offline I wanted to try. The recipe used veggie broth and finished it off with mixing in salsa at the end. Definitely yummy, would eat again.",
                    Author = "Teacup",
                    PublishDate = "03/03/21",
                    CategoryId = 2
                },
                new Content()
                {
                    Id = 3,
                    Title = "Thief",
                    Body = "So my dog is obsessed with our babies new toy. Keep in mind Washburne got three new toys only a week ago for his 6th birthday. This week I bought a new set of stacking teething rings for Miles and he has already stolen and destroyed two of the rings. Upon seeing how distraught my husband and I were when he destroyed the first two, he has decided that he should not chew them up. This has not stopped him from periodically stealing the smallest blue teething ring and hiding it around the house for himself.",
                    Author = "Teacup",
                    PublishDate = "03/05/21",
                    CategoryId = 3
                },
                new Content()
                {
                    Id = 4,
                    Title = "Crawling",
                    Body = "Miles is on the move. We have been frantically baby proofing the house as our 6 month old baby has already learned to crawl and pull himself up on furniture. We spent a ridiculous amount of money on two retractable mesh baby gates on Amazon this week to rig up a way to protect the entertainment center and two xbox series x's from his little grabbing hands. Pardon our dust.",
                    Author = "Teacup",
                    PublishDate = "03/04/21",
                    CategoryId = 4
                }
                );

        }
    }
}
