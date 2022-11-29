// <copyright file="MovieModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// MovieModifyForm contains the design and functions for manager options.
    /// </summary>
    public partial class MovieModifyForm : Form
    {
        /// <summary>
        /// String array to hold the information of the selected movie.
        /// </summary>
        private string[] movieSelection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieModifyForm"/> class.
        /// Default Constructor for MovieModifyForm.
        /// </summary>
        public MovieModifyForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Closes the form on button click.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fills listview with data on form load.
        /// </summary>
        /// <param name="sender">The form that was loaded.</param>
        /// <param name="e">Additional event arguments.</param>
        private void MovieModifyForm_Load(object sender, EventArgs e)
        {
            DataTable movie = this.movieTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(movie, this.MovieListView);

            ListViewHelper.ListViewData(movie, this.MovieListView);

            ListViewHelper.ListViewColumnAutoSize(movie, this.MovieListView);
        }

        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MovieListView.SelectedItems.Count > 0)
            {
                this.movieSelection = ListViewHelper.GetSelectedRow(this.MovieListView);

                this.movieIDTextBox.Text = this.movieSelection[0];
                this.movieTitleTextBox.Text = this.movieSelection[1];
                this.movieGenreTextBox.Text = this.movieSelection[2];
                this.movieLengthTextBox.Text = this.movieSelection[3];
                this.movieYearTextBox.Text = this.movieSelection[4];
                this.startDateTimePicker.Value = DateTime.Parse(this.movieSelection[5]);
                this.endDateTimePicker.Value = DateTime.Parse(this.movieSelection[6]);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

    }
}
