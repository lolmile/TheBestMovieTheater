// <copyright file="MovieModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Data;
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

        private List<TextBox> textBoxList;

        private List<Button> buttonList;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieModifyForm"/> class.
        /// Default Constructor for MovieModifyForm.
        /// </summary>
        public MovieModifyForm()
        {
            this.InitializeComponent();

            this.movieLengthTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.movieYearTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);

            this.startDateTimePicker.Value = DateTime.Today;
            this.endDateTimePicker.Value = DateTime.Today.AddDays(7);

            this.ModifyButton.Enabled = false;
            this.DeleteButton.Enabled = false;

            this.textBoxList = new List<TextBox> { this.movieIDTextBox, this.movieTitleTextBox, this.movieGenreTextBox, this.movieLengthTextBox, this.movieYearTextBox };
            this.buttonList = new List<Button> { this.AddButton, this.ModifyButton, this.DeleteButton };
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
            DataTable movieTable = this.movieTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(movieTable, this.MovieListView);
            ListViewHelper.ListViewData(movieTable, this.MovieListView);
            ListViewHelper.ListViewColumnAutoSize(movieTable, this.MovieListView);
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

                this.AddButton.Enabled = false;
                this.ModifyButton.Enabled = true;
                this.DeleteButton.Enabled = true;

                this.errorLabel.Visible = false;

                this.TextBoxEnabler(false);
                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            }
        }

        /// <summary>
        /// On button click, add the textbox information to the movie table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool validTitle = true;
            bool validGenre = true;
            bool validMinutes = true;
            bool validYear = true;
            bool validTime = true;

            this.errorLabel.Text = string.Empty;

            if (!UserInputValidation.DuplicateValidationCheck(this.MovieListView, this.movieTitleTextBox))
            {
                validTitle = false;
                this.errorLabel.Text = "*Title field must contain a unique title";
            }

            if (!UserInputValidation.EmptyFieldValidationCheck(this.movieGenreTextBox))
            {
                validGenre = false;
                this.errorLabel.Text += "\n*Genre field cannot be empty";
            }

            if (!UserInputValidation.NumericValidationCheck(this.movieLengthTextBox))
            {
                validMinutes = false;
                this.errorLabel.Text += "\n*Minutes field must contain only numeric values";
            }

            if (!UserInputValidation.NumericValidationCheck(this.movieYearTextBox, 4))
            {
                validYear = false;
                this.errorLabel.Text += "\n*Year field must contain four numeric values";
            }

            if (!UserInputValidation.DateTimeValidationCheck(this.startDateTimePicker, this.endDateTimePicker))
            {
                validTime = false;
                this.errorLabel.Text += "\n*Start time cannot be before today \n*End time must be after start time";
            }

            if (validTitle && validGenre && validMinutes && validYear && validTime)
            {
                this.movieTableAdapter.AddMovie(this.movieTitleTextBox.Text, this.movieGenreTextBox.Text, int.Parse(this.movieLengthTextBox.Text), int.Parse(this.movieYearTextBox.Text), this.startDateTimePicker.Value.ToString(), this.endDateTimePicker.Value.ToString());


                this.errorLabel.Visible = false;

                this.startDateTimePicker.Value = DateTime.Today;
                this.endDateTimePicker.Value = DateTime.Today.AddDays(7);

                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                ModifyFormHelper.ClearSelection(this.textBoxList, this.buttonList);

                ListViewHelper.ListViewData(this.movieTableAdapter.GetData(), this.MovieListView);
            }
            else
            {
                this.errorLabel.Visible = true;
            }
        }

        /// <summary>
        /// On button click, update selected movie for the movie table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            bool firstClick = true;
            bool validTitle = true;
            bool validGenre = true;
            bool validMinutes = true;
            bool validYear = true;
            bool validTime = true;

            this.errorLabel.Text = string.Empty;

            if (firstClick)
            {
                firstClick = false;
                this.DeleteButton.Enabled = false;
                this.TextBoxEnabler(true);
            }
            else
            {
                if (!UserInputValidation.EmptyFieldValidationCheck(this.movieTitleTextBox))
                {
                    validTitle = false;
                    this.errorLabel.Text = "*Title field must contain a unique title";
                }

                if (!UserInputValidation.EmptyFieldValidationCheck(this.movieGenreTextBox))
                {
                    validGenre = false;
                    this.errorLabel.Text += "\n*Genre field cannot be empty";
                }

                if (!UserInputValidation.NumericValidationCheck(this.movieLengthTextBox))
                {
                    validMinutes = false;
                    this.errorLabel.Text += "\n*Minutes field must contain only numeric values";
                }

                if (!UserInputValidation.NumericValidationCheck(this.movieYearTextBox, 4))
                {
                    validYear = false;
                    this.errorLabel.Text += "\n*Year field must contain four numeric values";
                }

                if (!UserInputValidation.DateTimeValidationCheck(this.startDateTimePicker, this.endDateTimePicker))
                {
                    validTime = false;
                    this.errorLabel.Text += "\n*Start time after today \n*End time must be after start time";
                }

                if (validTitle && validGenre && validMinutes && validYear && validTime)
                {
                    this.movieTableAdapter.UpdateMovie(this.movieTitleTextBox.Text, this.movieGenreTextBox.Text, int.Parse(this.movieLengthTextBox.Text), int.Parse(this.movieYearTextBox.Text), this.startDateTimePicker.Value.ToString(), this.endDateTimePicker.Value.ToString(), int.Parse(this.movieIDTextBox.Text));

                    this.errorLabel.Visible = false;

                    this.startDateTimePicker.Value = DateTime.Today;
                    this.endDateTimePicker.Value = DateTime.Today.AddDays(7);

                    ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                    ModifyFormHelper.ClearSelection(this.textBoxList, this.buttonList);

                    ListViewHelper.ListViewData(this.movieTableAdapter.GetData(), this.MovieListView);
                }
                else
                {
                    this.errorLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// On button click, calls the <see cref="ClearSelection"/> method.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.startDateTimePicker.Value = DateTime.Today;
            this.endDateTimePicker.Value = DateTime.Today.AddDays(7);
            this.errorLabel.Visible = false;

            this.TextBoxEnabler(true);

            ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            ModifyFormHelper.ClearSelection(this.textBoxList, this.buttonList);

            ListViewHelper.UnselectRow(this.MovieListView);
        }

        /// <summary>
        /// On button click, delete the selected movie from the movie table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.DeleteMovie(int.Parse(this.movieIDTextBox.Text), this.movieTitleTextBox.Text);

            this.startDateTimePicker.Value = DateTime.Today;
            this.endDateTimePicker.Value = DateTime.Today.AddDays(7);

            ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            ModifyFormHelper.ClearSelection(this.textBoxList, this.buttonList);
            this.TextBoxEnabler(true);

            ListViewHelper.ListViewData(this.movieTableAdapter.GetData(), this.MovieListView);
        }

        /// <summary>
        /// Enables or disables textboxes depending on parameter.
        /// </summary>
        /// <param name="isEnabled">Determine if textboxes are enabled. </param>
        private void TextBoxEnabler(bool isEnabled)
        {
            if (isEnabled)
            {
                this.movieTitleTextBox.Enabled = true;
                this.movieGenreTextBox.Enabled = true;
                this.movieLengthTextBox.Enabled = true;
                this.movieYearTextBox.Enabled = true;
                this.startDateTimePicker.Enabled = true;
                this.endDateTimePicker.Enabled = true;
            }
            else
            {
                this.movieTitleTextBox.Enabled = false;
                this.movieGenreTextBox.Enabled = false;
                this.movieLengthTextBox.Enabled = false;
                this.movieYearTextBox.Enabled = false;
                this.startDateTimePicker.Enabled = false;
                this.endDateTimePicker.Enabled = false;
            }
        }
    }
}
