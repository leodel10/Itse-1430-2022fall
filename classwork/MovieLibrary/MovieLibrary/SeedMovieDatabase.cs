using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public static class SeedMovieDatabaseExtensions 
    {
        // Extention method reqirements
        // 1. piblic/internal static class
        // 2. public/internal static method
        // 2. first param must be the extended type
        // 4. first param must be preceeded by this 
    
        public static void Seed( this IMovieDatabase database)
        {
            //var movies = new Movie[3];

            //Object initializer syntax
            //new Movie("Jaws", "PG");
            //var movie = new Movie();
            //movie.Title = "Jaws";
            //movie.Rating = "PG";
            //movie.RunLegnth = 210;
            //movie.ReleaseYear = 1977;
            //movie.Description = "Shark eats people";
            //movie.IsClassic = true;
            //Add(movie, out var error);  //movies[0] for var

            var movies = new Movie[] {
                new Movie {
                Title = "Jaws",
                Rating = "PG",
                RunLegnth = 210,
                ReleaseYear = 1977,
                Description = "Shark eats people",
                IsClassic = true,
            },
                new Movie {
                Title = "Jaws 2",
                Rating = "PG-13",
                RunLegnth = 220,
                ReleaseYear = 1985,
                Description = "Shark eats people...again",
            },

                new Movie {
                Title = "Ice Age",
                Rating = "G",
                RunLegnth = 210,
                ReleaseYear = 2002,
                Description = "Ice age happens",
                IsClassic = true,
            }

           };

            foreach (var movie in movies)
                database.Add(movie, out var error);

        }
    }
}
