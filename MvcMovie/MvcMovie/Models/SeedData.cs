using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                     new Movies
                     {
                         Title = "When Harry Met Sally",
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Genre = "Romantic Comedy",
                         Rating = "R",
                         Price = 7.99M
                     },

                     new Movies
                     {
                         Title = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Rating = "R",                        
                         Price = 8.99M
                     },

                     new Movies
                     {
                         Title = "Ghostbusters 2",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Rating = "R",
                         Price = 9.99M
                     },

                   new Movies
                   {
                       Title = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Rating = "R",
                       Price = 3.99M,
                   },

                   new Movies
                   {
                       Title = "Matt is a Boosted Monkey",
                       ReleaseDate = DateTime.Parse("1990-4-15"),
                       Genre = "Life",
                       Rating = "R",                     
                       Price = 1.20M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}