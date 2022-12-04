// <copyright file="ShowtimeModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// ShowtimeModifyForm contains the design and functions for manager showtimes.
    /// </summary>
    public partial class ShowtimeModifyForm : Form
    {
        /// <summary>
        /// List of buttons.
        /// </summary>
        private readonly List<Button> buttonList;

        /// <summary>
        /// String array to hold the information of the selected showtime.
        /// </summary>
        private string[] showTimeInfo;

        /// <summary>
        /// Holds boolean value to determine the first click of the modify button.
        /// </summary>
        private bool modifyFirstClick = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowtimeModifyForm"/> class.
        /// Default constructor fro ShowtimeModifyForm.
        /// </summary>
        public ShowtimeModifyForm()
        {
            this.InitializeComponent();

            this.ModifyButton.Enabled = false;
            this.DeleteButton.Enabled = false;

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
        private void ShowtimeModifyForm_Load(object sender, EventArgs e)
        {
            DataTable showtime = this.showtimeTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(showtime, this.ShowtimeListView);
            ListViewHelper.ListViewData(showtime, this.ShowtimeListView);
            ListViewHelper.ListViewColumnAutoSize(showtime, this.ShowtimeListView);
        }

        /// <summary>
        /// Fills textbox with showtime information when a row is selected.
        /// </summary>
        /// <param name="sender">The listview index that was changed.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ShowtimeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ShowtimeListView.SelectedItems.Count > 0)
            {
                this.showTimeInfo = ListViewHelper.GetSelectedRow(this.ShowtimeListView);

                this.showTimeIDTextBox.Text = this.showTimeInfo[0];
                this.showTimeTimePicker.Text = this.showTimeInfo[1];
                this.showTimeTimePicker.Enabled = false;

                this.errorLabel.Visible = false;
                this.modifyFirstClick = true;

                ModifyFormHelper.ButtonEnabler(this.buttonList, true);
            }
        }

        /// <summary>
        /// On button click, add new showtime to the Showtime table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool validShowtime = true;

            if (!UserInputValidation.DuplicateValidationCheck(this.ShowtimeListView, this.showTimeTimePicker))
            {
                validShowtime = false;
                this.errorLabel.Text = "*Showtime must be unique";
            }

            if (validShowtime)
            {
                this.showtimeTableAdapter.AddShowtime(this.showTimeTimePicker.Text);

                this.errorLabel.Visible = false;

                ListViewHelper.ListViewData(this.showtimeTableAdapter.GetData(), this.ShowtimeListView);
            }
            else
            {
                this.errorLabel.Visible = true;
            }
        }

        /// <summary>
        /// On button click, update the Showtime table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments</param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            bool validShowtime = true;

            this.errorLabel.Text = string.Empty;

            if (this.modifyFirstClick)
            {
                this.modifyFirstClick = false;
                this.DeleteButton.Enabled = false;

                this.showTimeTimePicker.Enabled = true;
            }
            else
            {
                if (!UserInputValidation.DuplicateValidationCheck(this.ShowtimeListView, this.showTimeTimePicker))
                {
                    validShowtime = false;

                    this.errorLabel.Text = "*Showtime must be unique";
                }

                if (validShowtime)
                {
                    this.showtimeTableAdapter.UpdateShowtime(this.showTimeTimePicker.Text, int.Parse(this.showTimeIDTextBox.Text));

                    this.modifyFirstClick = true;

                    this.errorLabel.Visible = false;

                    this.showTimeIDTextBox.Text = string.Empty;
                    this.showTimeTimePicker.Text = default;

                    ModifyFormHelper.ButtonEnabler(this.buttonList, false);

                    ListViewHelper.ListViewData(this.showtimeTableAdapter.GetData(), this.ShowtimeListView);
                }
                else
                {
                    this.errorLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// On button click, delete a showtime from the Showtime table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event argument.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.showtimeTableAdapter.DeleteShowtime(int.Parse(this.showTimeIDTextBox.Text), this.showTimeTimePicker.Text);

            this.errorLabel.Visible = false;

            this.showTimeIDTextBox.Text = string.Empty;
            this.showTimeTimePicker.Text = default;

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);

            ListViewHelper.ListViewData(this.showtimeTableAdapter.GetData(), this.ShowtimeListView);
        }

        /// <summary>
        /// On button click, resets form to default state.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;

            this.modifyFirstClick = true;

            this.showTimeIDTextBox.Text = string.Empty;

            this.showTimeTimePicker.Enabled = true;
            this.showTimeTimePicker.Text = "00:00";

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);

            ListViewHelper.UnselectRow(this.ShowtimeListView);
        }
    }
}
