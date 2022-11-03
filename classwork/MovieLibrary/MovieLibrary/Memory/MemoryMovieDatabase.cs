using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override Movie AddCore ( Movie movie)
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
            //if (movie == null)
            //{
            //    errorMessage = "Movie cannot be null";
            //    return null;
            //};

            ////use IValidatableObject 
            //if (!new ObjectValidator().IsValid(movie, out errorMessage))
            //    return null;


            ////must be unique
            //var existing = FindByTitle(movie.Title);
            //if (existing != null)
            //{
            //    errorMessage = "Movie must be unique";
            //    return null;
            //};


            //add
            movie.Id = _id++;
            _movies.Add(movie.Clone());

            return movie;
        }

        protected override Movie GetCore ( int id )
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

        //public Movie[] GetAll()
        //When method returns IEnuma
        protected override IEnumerable<Movie> GetAllCore ()
        {
            //var items  = new List<Movie>();

            //When returning an array, clone it 
            //var items = new Movie[_movies.Count];
            //for (var index = 0; index < _movies.Length; ++index)
            //    items[index] = _movies[index]?.Clone();
            //var index = 0;
            foreach (var movie in _movies)
            {
                //items[index++] = movie.Clone();
                //items.Add(movie.Clone());
                yield return movie.Clone();
            };

            //Empty array
            //new Movie[0];

            //return items;
        }


        protected override void RemoveCore ( int id )
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

        protected override void UpdateCore ( int id, Movie movie)
        {

           var oldMovie = FindById (id);

            //Copy
            movie.CopyTo(oldMovie);
            oldMovie.Id = id;

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
        protected override Movie FindByTitle ( string title )
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
