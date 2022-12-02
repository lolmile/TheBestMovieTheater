// <copyright file="ShowtimeModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// ShowtimeModifyForm contains the design and functions for manager showtimes.
    /// </summary>
    public partial class ShowtimeModifyForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowtimeModifyForm"/> class.
        /// Default constructor fro ShowtimeModifyForm.
        /// </summary>
        public ShowtimeModifyForm()
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
        private void ShowtimeModifyForm_Load(object sender, EventArgs e)
        {
            DataTable showtime = this.showtimeTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(showtime, this.ShowtimeListView);

            ListViewHelper.ListViewData(showtime, this.ShowtimeListView);

            ListViewHelper.ListViewColumnAutoSize(showtime, this.ShowtimeListView);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
