namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var child = new MovieForm();

            //Showing form modally
            if (child.ShowDialog(this) != DialogResult.OK)
                return;
            //child.Show();

            //TODO save this off 
             _movie = child.SelectedMovie;
            UpdateUI();
        }

        private Movie _movie;

        protected override void OnFormClosing (FormClosingEventArgs e)
        {
            base.OnFormClosing (e);

            if (Confirm("Are you sure you want to leave?", "Close"))
                return;

            //stop the event 
            e.Cancel = true;

        }

        protected override void  OnFormClosed ( FormClosedEventArgs e)
        {
            base.OnFormClosed( e );
        }
  
        private void UpdateUI()
        {
            _lstMovies.Items.Clear();
            if (_movie != null)
            {
                _lstMovies.Items.Add(_movie);
            }
        }

        private Movie GetSelectedMovie()
        {
            return _movie;
        }


        private bool Confirm ( string message, string title )
        {
            DialogResult result = MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;


            if (!Confirm($"Are you sure you want to delete the movie '{movie.Title}'?", "Delete"))
                return;

            //todo
            _movie = null;
            UpdateUI();
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            var child = new MovieForm();
            child.SelectedMovie = movie;


            //Showing form modally
            if (child.ShowDialog(this) != DialogResult.OK)
                return;
            //child.Show();

            //TODO save this off 
            _movie = child.SelectedMovie;
            UpdateUI();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutForm();

            about.ShowDialog();
        }
    }

}
