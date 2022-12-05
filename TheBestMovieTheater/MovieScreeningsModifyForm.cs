// <copyright file="MovieScreeningsModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MovieScreeningsModifyForm : Form
    {
        /// <summary>
        /// List of textBoxes.
        /// </summary>
        private readonly List<TextBox> textBoxList;

        /// <summary>
        /// List of buttons.
        /// </summary>
        private readonly List<Button> buttonList;

        /// <summary>
        /// String array to hold the movies screening information.
        /// </summary>
        private string[] movieScreeningInfo;

        /// <summary>
        /// Holds boolean value to determine the first click of the modify button.
        /// </summary>
        private bool modifyFirstClick = true;

        public MovieScreeningsModifyForm()
        {
            this.InitializeComponent();


        }

        private void MovieScreeningsModifyForm_Load(object sender, EventArgs e)
        {
            DataTable movieScreeningTable = this.movieInfoBridgeTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewData(movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewColumnAutoSize(movieScreeningTable, this.MovieScreeningListView);
        }
    }
}
