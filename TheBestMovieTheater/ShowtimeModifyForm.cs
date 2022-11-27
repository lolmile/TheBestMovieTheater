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
        /// Closes the current form reopening ManagerMenuForm.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowtimeModifyForm_Load(object sender, EventArgs e)
        {
            DataTable showtime = this.showtimeTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(showtime, this.ShowtimeListView);

            ListViewHelper.ListViewData(showtime, this.ShowtimeListView);
        }
    }
}
