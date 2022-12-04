// <copyright file="ScreeningRoomModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// ScreeningRoomModifyForm contains the design and functions for screening room information.
    /// </summary>
    public partial class ScreeningRoomModifyForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreeningRoomModifyForm"/> class.
        /// Default constructor for ScreeningRoomModifyForm.
        /// </summary>
        public ScreeningRoomModifyForm()
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
        private void ScreeningRoomModifyForm_Load(object sender, EventArgs e)
        {
            DataTable screeningroom = this.screeningRoomTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(screeningroom, this.ScreeningRoomListView);

            ListViewHelper.ListViewData(screeningroom, this.ScreeningRoomListView);

            ListViewHelper.ListViewColumnAutoSize(screeningroom, this.ScreeningRoomListView);
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
