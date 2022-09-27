namespace MovieLibrary
{
    /// <summary>Represents a movie.</summary> 
    public class Movie
    {
        public int Id { get; private set; }
        /// <summary> Gets or sets a title. /// </summary>
        public string Title
        {
            // string get_Title ()
            get 
             {
                return string.IsNullOrEmpty(_title) ? "" : _title; 
               
             }

            // void set_Title ( string value ) 
            set { _title = string.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _title;

        //public string GetTitle ()
        //{
        //    return _title;
        //}
        //public void SetTitle ( string title )
        //{
        //    //this._title = title;
        //    _title = title;
        //}

        public string Description
        {
            get { return string.IsNullOrEmpty(_description) ? "" : _description; }
            set { _description = string.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _description;

        /// <summary> Gets or sets run lenght in minutes /// </summary>
        //public int RunLegnth
        //{
        //    get { return _runLegnth; }
        //    set { _runLegnth = value; }
        //}
        //private int _runLegnth = 0;
        //autoproperty
        public int RunLegnth { get; set; }


        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}
        //private int _releaseYear = 1900;
        public int ReleaseYear { get; set; } = 1900;
        public string Rating
        {
            get {  return string.IsNullOrEmpty(_rating) ? "" : _rating; }
            set { _rating = string.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _rating;

        public bool IsClassic { get; set; }

        //public bool IsBlackAndWhite () { return return _releaseYear < 1939;   }
        public bool IsBlackAndWhite
        {
            get { return ReleaseYear < 1939; }
            //set { }
        }
        /// <summary>Clones the existing movie.</summary>
        /// <returns>C copy of the movie.</returns>
        public Movie Clone ()
        {
            var movie = new Movie ();
            CopyTo (movie);

            return movie;
        }

        /// <summary>Copy the movie to another instance.</summary>
        /// <param name="movie">Movie to copy into </param>
        public void CopyTo ( /* Movie this */Movie movie)
        {
            //var areEqual = _title == this._title;

            movie.Title = Title;
            movie.Description = Description;    //this,description
            movie.RunLegnth = RunLegnth;
            movie.ReleaseYear = ReleaseYear;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic; 
        }

    }
    
}