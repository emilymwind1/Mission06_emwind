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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                
                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Drama",
                    Title = "We Bought a Zoo",
                    Year = 2011,
                    Director = "Cameron Crowe",
                    Rating = "PG"
                },

                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Romance",
                    Title = "The Longest Ride",
                    Year = 2015,
                    Director = "George Tillman Jr",
                    Rating = "PG-13"
                },

                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Romance/Drama",
                    Title = "Pride and Prejudice",
                    Year = 2005,
                    Director = "Joe Wright",
                    Rating = "PG"
                }
            );
        }
    }
}
