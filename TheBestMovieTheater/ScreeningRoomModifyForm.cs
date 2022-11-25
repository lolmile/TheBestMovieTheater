// <copyright file="ScreeningRoomModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
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
            // TODO: This line of code loads data into the 'tBMT_DBDataSetLocal.vManager_Rooms' table. You can move, or remove it, as needed.
            this.vManager_RoomsTableAdapter.Fill(this.tBMT_DBDataSetLocal.vManager_Rooms);
        }
    }
}
