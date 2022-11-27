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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScreeningRoomModifyForm_Load(object sender, EventArgs e)
        {
            DataTable screeningroom = this.screeningRoomTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(screeningroom, this.ScreeningRoomListView);

            ListViewHelper.ListViewData(screeningroom, this.ScreeningRoomListView);
        }
    }
}
