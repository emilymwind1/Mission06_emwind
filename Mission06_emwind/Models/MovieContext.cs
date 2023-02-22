using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_emwind.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                    new Category { CategoryID = 2, CategoryName = "Comedy" },
                    new Category { CategoryID = 3, CategoryName = "Drama" },
                    new Category { CategoryID = 4, CategoryName = "Romance" },
                    new Category { CategoryID = 5, CategoryName = "Family" },
                    new Category { CategoryID = 6, CategoryName = "Horror/Suspense" },
                    new Category { CategoryID = 7, CategoryName = "Miscellaneous" },
                    new Category { CategoryID = 8, CategoryName = "Television" },
                    new Category { CategoryID = 9, CategoryName = "VHS" }
                );

            mb.Entity<ApplicationResponse>().HasData(
                
                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 3,
                    Title = "We Bought a Zoo",
                    Year = 2011,
                    Director = "Cameron Crowe",
                    Rating = "PG"
                },

                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryID = 4,
                    Title = "The Longest Ride",
                    Year = 2015,
                    Director = "George Tillman Jr",
                    Rating = "PG-13"
                },

                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryID = 4,
                    Title = "Pride and Prejudice",
                    Year = 2005,
                    Director = "Joe Wright",
                    Rating = "PG"
                }
            );
        }
    }
}
