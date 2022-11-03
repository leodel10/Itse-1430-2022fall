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

        protected override void OnLoad (EventArgs e )
        {
            base.OnLoad(e);


            //Do any init jst before UI is rendered
            if(SelectedMovie != null)
            {
                //Load UI
                _txtTitle.Text = SelectedMovie.Title;
                _txtDescription.Text = SelectedMovie.Description;
                _cbRating.Text = SelectedMovie.Rating;

                _chkIsClassic.Checked = SelectedMovie.IsClassic;
                _txtRunLegnth.Text = SelectedMovie.RunLegnth.ToString();
                _txtReleaseYear.Text = SelectedMovie.ReleaseYear.ToString();
            };
            //Force Validation 
            ValidateChildren();
        }

        private void Onsave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())   //validates controls 
                return;

            var btn = sender as Button;

            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _cbRating.Text;

            movie.IsClassic = _chkIsClassic.Checked;
            movie.RunLegnth = GetInt32(_txtRunLegnth);
            movie.ReleaseYear = GetInt32(_txtReleaseYear);

           // if (!new ObjectValidator().IsValid(movie, out var error))
                if (!ObjectValidator.IsValid(movie, out var error))
                {
                DisplayError(error, "Save");
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
            MessageBox.Show(this,message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetInt32 (TextBox control)
        {
            
            if (Int32.TryParse(control.Text, out var result))
                return result;

            return -1;

        }


        //VALIDATING 
        private void OnValidateTitle ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                //notvalid
                _errors.SetError(control, "Title is required");
                e.Cancel = true;
            }else
            {
                //valiod
                _errors.SetError(control, "");
            };
        }

        private void OnValidateRating ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                //notvalid
                _errors.SetError(control, "Rating is required");
                e.Cancel = true;
            } else
            {
                //valiod
                _errors.SetError(control, "");
            };
        }

        private void OnValidateReleaseYear ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as TextBox;


            var value = GetInt32(control);
            if (value < 1900)
            {
                //notvalid
                _errors.SetError(control, "Release year must be at least 1900");
                e.Cancel = true;
            } else
            {
                //valiod
                _errors.SetError(control, "");
            };
        }


        private void OnValidateRunLegnth ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetInt32(control);

            if (value < 0)
            {
                //notvalid
                _errors.SetError(control, "Runlegnth must be >= 0");
                e.Cancel = true;
            } else
            {
                //valiod
                _errors.SetError(control, "");
            };
        }
    }
}
