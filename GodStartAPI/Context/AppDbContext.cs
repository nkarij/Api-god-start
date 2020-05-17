using AutoMapper.Configuration;
using GodStartAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Context
{
    public class AppDbContext : DbContext
    {

        // this is to get the appsetting.json, fx the connectionstring.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostNumber> PostNumbers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DateTime LocalDateNow = DateTime.Now;
            DateTime ExpirationLocalDate = LocalDateNow.AddDays(30);

            // seed data
            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = 1,
                Title = "JobTitle 1",
                SubTitle = "",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dignissim cras tincidunt lobortis feugiat vivamus. Tellus at urna condimentum.",
                ImageUrl = "",
                CreationDate = LocalDateNow,
                ExpirationDate = ExpirationLocalDate,
                CategoryId = 1,
                PostNumberId = 1,
            });

            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = 2,
                SubTitle = "",
                ImageUrl = "",
                CategoryId = 1,
                PostNumberId = 1,
                Title = "JobTitle 2",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dignissim cras tincidunt lobortis feugiat vivamus. Tellus at urna condimentum."
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "IT"
            });

            modelBuilder.Entity<PostNumber>().HasData(new PostNumber
            {
                Id = 1,
                Number = 2500,
            });

            modelBuilder.Entity<Location>().HasData(new Location
            {
                   Id = 1,
                   Name = "Valby",
                   PostNumberId = 1,
            });


        }



    }
}
