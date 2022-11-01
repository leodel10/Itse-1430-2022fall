using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public abstract class MovieDatabase : IMovieDatabase
    {

        public Movie Add ( Movie movie, out string errorMessage )
        {
            

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
            movie = AddCore(movie);
            //movie.Id = _id++;
            //_movies.Add(movie.Clone());

            errorMessage = null;
            return movie;
        }

        protected abstract Movie AddCore ( Movie movie );

        public Movie Get ( int id )
        {
            if (id <= 0)
                return null;
            //enumarate array looking for match 
            //for (var index = 0; index < _movies.Length; ++index)
            //if (_movies[index]?.Id == id)
            //return _movies[index].Clone(); //clone because of ref type 

            //foreach (var movie in _movies)
            //    if (movie?.Id == id)
            //        return movie.Clone(); //clone because of ref type 

            return GetCore(id);
        }

        protected abstract Movie GetCore ( int id );

        //public Movie[] GetAll()
        //When method returns IEnuma
        public IEnumerable<Movie> GetAll ()
        {
            return GetAllCore();
            //var items  = new List<Movie>();

            //When returning an array, clone it 
            //var items = new Movie[_movies.Count];
            //for (var index = 0; index < _movies.Length; ++index)
            //    items[index] = _movies[index]?.Clone();
            //var index = 0;

            //foreach (var movie in _movies)
            //{
            //    //items[index++] = movie.Clone();
            //    //items.Add(movie.Clone());
            //    yield return movie.Clone();
            //};

            //Empty array
            //new Movie[0];

            //return items;
        }

        protected abstract IEnumerable<Movie> GetAllCore ();

        public void Remove ( int id )
        {
            if (id <=0)
                return;

            RemoveCore(id);
            //enumarate array looking for match 
            //for (var index = 0; index < _movies.Count; ++index)
            //    if (_movies[index]?.Id == id)
            //    {

            //        //_movies[index] = null;  
            //        _movies.RemoveAt(index);
            //        return;
            //    }
        }

        protected abstract void RemoveCore ( int id );

        public bool Update ( int id, Movie movie, out string errorMessage )
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
            var oldMovie = GetCore(id);
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

            UpdateCore(id, movie);

            //Copy
            //movie.CopyTo(oldMovie);
            //oldMovie.Id = id;

            errorMessage = null;
            return true;
        }

        protected abstract void UpdateCore ( int id, Movie movie );

        protected abstract Movie FindByTitle ( string title );
       


    }
}
