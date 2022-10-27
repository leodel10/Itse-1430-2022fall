using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        public MovieDatabase ()
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
            var movie = new Movie() {
                Title = "Jaws",
                Rating = "PG",
                RunLegnth = 210,
                ReleaseYear = 1977,
                Description = "Shark eats people",
                IsClassic = true,
            };
            Add(movie, out var error);

            movie = new Movie() {
                Title = "Jaws 2",
                Rating = "PG-13",
                RunLegnth = 220,
                ReleaseYear = 1985,
                Description = "Shark eats people...again",
            };
            Add(movie, out error);

            movie = new Movie() {
            Title = "Ice Age",
            Rating = "G",
            RunLegnth = 210,
            ReleaseYear = 2002,
            Description = "Ice age happens",
            IsClassic = true,
            };
            Add(movie, out error);




        }

        public virtual Movie Add ( Movie movie, out string errorMessage )
        {
            //ARRAY
            //Find first null elemtn
            //if found then set to new movie
            //else
            //  resize the array 
            //copy all existing elements over
            //set 'oldarray.Length' to new movie 

            //var numberOfElements = _movies.Length;

            //Validate movie
            if (movie == null)
            {
                errorMessage = "Movie cannot be null";
                return null;
            };

            //use IValidatableObject 
            if (!new ObjectValidator().IsValid(movie, out errorMessage))
                return null;


            //must be unique
            var existing = FindByTitle(movie.Title);
            if (existing != null)
            {
                errorMessage = "Movie must be unique";
                return null;
            };

           
            //add
            movie.Id = _id++;
            _movies.Add(movie.Clone());

            errorMessage = null;
            return movie;
        }

        public Movie Get ( int id )
        {

            //enumarate array looking for match 
            //for (var index = 0; index < _movies.Length; ++index)
            //if (_movies[index]?.Id == id)
            //return _movies[index].Clone(); //clone because of ref type 

            foreach (var movie in _movies)
                if (movie?.Id == id)
                    return movie.Clone(); //clone because of ref type 

            return null;
        }

        public Movie[] GetAll()
        {
       
            var items = new Movie[_movies.Count];
            //for (var index = 0; index < _movies.Length; ++index)
            //    items[index] = _movies[index]?.Clone();
            var index = 0;
            foreach (var movie in _movies)
                items[index++] = movie.Clone();

            //Empty array
            //new Movie[0];

            return items;
        }


        public void Remove (int id)
        {
            //enumarate array looking for match 
            for (var index = 0; index < _movies.Count; ++index)
                if (_movies[index]?.Id == id)
                {

                    //_movies[index] = null;  
                    _movies.RemoveAt(index);
                    return;
                }
        }

        public bool Update (int id, Movie movie, out string errorMessage)
        {
         
            //Validate movie
            if (movie == null)
            {
                errorMessage = "Movie cannot be null";
                return false;
            };
            if (!new ObjectValidator().IsValid(movie, out errorMessage))
                return false;
            //Movie must already exist 
            var oldMovie = FindById(id);
            if (oldMovie == null)
            {
                errorMessage = "Movie does not exist";
                return false;
            };

            //must be unique
            var existing = FindByTitle(movie.Title);
            if (existing != null && existing.Id != id)
            {
                errorMessage = "Movie must be unique";
                return false;
            };

            //Copy
            movie.CopyTo(oldMovie);
            oldMovie.Id = id;

            errorMessage = null;
            return true;
        }

        private Movie FindById ( int id )
        {
            //StringCompare
            //ICompare<Task>
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }
        private Movie FindByTitle ( string title )
        {
            foreach (var movie in _movies)
                if (String.Equals(movie.Title, title, StringComparison.OrdinalIgnoreCase))
                    return movie;

            return null;
        }

        private int _id = 1;

        //Systems.Collectoins.Generic  go to for data structures outside of list
        //private Movie[] _movies = new Movie[100]
        private List<Movie> _movies = new List<Movie>();
        //List<string>;
        //List<int>;

    }
}
