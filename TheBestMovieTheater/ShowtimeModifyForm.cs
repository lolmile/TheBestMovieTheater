// <copyright file="ShowtimeModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
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

        /// <summary>
        /// Loads data into objects while the form loads.
        /// </summary>
        /// <param name="sender">The object to be loaded.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ShowtimeModifyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBMT_DBDataSetLocal.vManager_Showtimes' table. You can move, or remove it, as needed.
            this.vManager_ShowtimesTableAdapter.Fill(this.tBMT_DBDataSetLocal.vManager_Showtimes);
        }
    }
}
