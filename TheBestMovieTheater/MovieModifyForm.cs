﻿// <copyright file="MovieModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// MovieModifyForm contains the design and functions for manager options.
    /// </summary>
    public partial class MovieModifyForm : Form
    {
        /// <summary>
        /// String array to hold the information of the selected movie.
        /// </summary>
        private string[] movieInfo;

        /// <summary>
        /// Int variable to hold the number of valid tests.
        /// </summary>
        private int validCounter;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieModifyForm"/> class.
        /// Default Constructor for MovieModifyForm.
        /// </summary>
        public MovieModifyForm()
        {
            this.InitializeComponent();

            this.movieLengthTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.movieYearTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
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

        /// <summary>
        /// Fills textbox with movie information when a row is selected.
        /// </summary>
        /// <param name="sender">The listview index that was changed.</param>
        /// <param name="e">Additional event arguments.</param>
        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MovieListView.SelectedItems.Count > 0)
            {
                this.movieInfo = ListViewHelper.GetSelectedRow(this.MovieListView);

                this.movieIDTextBox.Text = this.movieInfo[0];
                this.movieTitleTextBox.Text = this.movieInfo[1];
                this.movieGenreTextBox.Text = this.movieInfo[2];
                this.movieLengthTextBox.Text = this.movieInfo[3];
                this.movieYearTextBox.Text = this.movieInfo[4];
                this.startDateTimePicker.Value = DateTime.Parse(this.movieInfo[5]);
                this.endDateTimePicker.Value = DateTime.Parse(this.movieInfo[6]);
            }
        }

        /// <summary>
        /// On button click, adds the textbox information into the TBMT_DB database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.validCounter = 0;

            this.validCounter += UserInputValidation.DuplicateValidationCheck(this.MovieListView ,this.movieTitleTextBox);
            this.validCounter += UserInputValidation.EmptyFieldValidationCheck(this.movieGenreTextBox);
            this.validCounter += UserInputValidation.NumericValidationCheck(this.movieLengthTextBox);
            this.validCounter += UserInputValidation.NumericValidationCheck(this.movieYearTextBox);
            this.validCounter += UserInputValidation.DateTimeValidationCheck(this.startDateTimePicker, this.endDateTimePicker);

            if (this.validCounter == 5)
            {
                // Commented out for testing
                // this.movieTableAdapter.AddMovie(this.movieTitleTextBox.Text, this.movieGenreTextBox.Text, int.Parse(this.movieLengthTextBox.Text), int.Parse(this.movieYearTextBox.Text), this.startDateTimePicker.Value.ToString(), this.endDateTimePicker.Value.ToString());

                MessageBox.Show("Movie Added!");

                ListViewHelper.ListViewData(this.movieTableAdapter.GetData(), this.MovieListView);

                this.ClearSelection();

            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearSelection();
        }

        private void ClearSelection()
        {
            string defaultDate = "2000-01-01";

            this.movieIDTextBox.Text = string.Empty;
            this.movieTitleTextBox.Text = string.Empty;
            this.movieGenreTextBox.Text = string.Empty;
            this.movieLengthTextBox.Text = string.Empty;
            this.movieYearTextBox.Text = string.Empty;
            this.startDateTimePicker.Value = DateTime.Parse(defaultDate);
            this.endDateTimePicker.Value = DateTime.Parse(defaultDate);

            this.movieTitleTextBox.BackColor = Color.White;
            this.movieGenreTextBox.BackColor = Color.White;
            this.movieLengthTextBox.BackColor = Color.White;
            this.movieYearTextBox.BackColor = Color.White;

            if (this.MovieListView.SelectedIndices.Count > 0)
            {
                this.MovieListView.SelectedItems[0].Selected = false;
            }
        }
    }
}
