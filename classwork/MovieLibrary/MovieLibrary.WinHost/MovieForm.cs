using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        /// <summary> Gets or sets the movie being edited </summary>
        public Movie SelectedMovie { get; set; }

        private void Onsave ( object sender, EventArgs e )
        {
            //TODO add validation 
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _cbRating.Text;

            movie.IsClassic = _chkIsClassic.Checked;
            movie.RunLegnth = GetInt32(_txtRunLegnth);
            movie.ReleaseYear = GetInt32(_txtReleaseYear);

            if (movie.Title.Length == 0)
            {
                DisplayError("Title is required", "Save");
                return;
            };

            if (movie.Rating.Length == 0)
            {
                DisplayError("Rating is required", "Save");
                    return;
            };

            if (movie.RunLegnth < 0)
            {
                DisplayError("RunLegnth must be >=0", "Save");
                return;
            };

            if (movie.ReleaseYear < 1900)
            {
                DisplayError("Release Year must be >=1900", "Save");
                return;
            };

            //Get Rid of form 
            //Setting Form's DialogReult to a reasonable
            //Call Close()
            SelectedMovie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetInt32 (TextBox control)
        {
            if (Int32.TryParse(control.Text, out var result))
                return result;

            return -1;

        }
    }
}
