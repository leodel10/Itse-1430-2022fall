namespace MovieLibrary
{
    /// <summary>Represents a movie.</summary> 
    public class Movie
    {

        public Movie () : this("", "")
        { }

        //constructor changing 
        //Allows for calling another constructor type 
        public Movie( string title ) : this(title, "")
        {}

        public Movie ( string title, string description )  :base() //Object.ctor()    
        {
            Title = title;
            Description = description;
        }

        public int Id { get; private set; }
        /// <summary> Gets or sets a title. /// </summary>
        public string Title
        {
            get 
             {
                return _title ?? "";                                        //same 
             }
            set { _title = value?.Trim() ?? ""; }
        }
        private string _title;

        public string Description
        {
            //get { return string.IsNullOrEmpty(_description) ? "" : _description; }
            get { return _description ?? ""; }
            //set { _description = string.IsNullOrEmpty(value) ? "" : value.Trim(); }
            set { _description = value?.Trim() ?? ""; }
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

        public int ReleaseYear { get; set; } = 1900;
        public string Rating
        {
            //get {  return string.IsNullOrEmpty(_rating) ? "" : _rating; }
            get {  return _rating ?? ""; }
            //set { _rating = string.IsNullOrEmpty(value) ? "" : value.Trim(); }
            set { _rating = value?.Trim() ?? ""; }
        }
        private string _rating;

        public bool IsClassic { get; set; }

        //public bool IsBlackAndWhite () { return return _releaseYear < 1939;   }
        public bool IsBlackAndWhite
        {
            get { return ReleaseYear < YearColorWasIntroduced; }
        }
        public const int YearColorWasIntroduced = 1939;         //field 

        /// <summary>Clones the existing movie.</summary>
        /// <returns>C copy of the movie.</returns>
        public Movie Clone ()
        {
            var movie = new Movie ("Title");
            CopyTo (movie);

            return movie;
        }

        /// <summary>Copy the movie to another instance.</summary>
        /// <param name="movie">Movie to copy into </param>
        public void CopyTo ( /* Movie this */Movie movie)
        {

            movie.Title = Title;
            movie.Description = Description;    //this,description
            movie.RunLegnth = RunLegnth;
            movie.ReleaseYear = ReleaseYear;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic; 
        }
        
        //Equals & GetHashCodes
        //GetType
        public override string ToString ()
        {
            var str = base.ToString ();       //calls bae type impl
            return Title;
        }
    }
}