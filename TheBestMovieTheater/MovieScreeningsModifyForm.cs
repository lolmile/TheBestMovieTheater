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

            this.movieIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.showtimeIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.screeningRoomIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);

            this.textBoxList = new List<TextBox> { this.movieScreeningIDTextBox, this.movieIDTextBox, this.showtimeIDTextBox, this.screeningRoomIDTextBox };
            this.buttonList = new List<Button> { this.AddButton, this.ModifyButton, this.DeleteButton };

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);
        }

        private void MovieScreeningsModifyForm_Load(object sender, EventArgs e)
        {
            DataTable movieScreeningTable = this.movieInfoBridgeTableAdapter.GetData();
            DataTable movieTable = this.movieTableAdapter.GetData();
            DataTable showtimeTable = this.showtimeTableAdapter.GetData();
            DataTable screeningRoomTable = this.screeningRoomTableAdapter.GetData();

            // Fill Movie Screenings list view.
            ListViewHelper.ListViewHeaders(movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewData(movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewColumnAutoSize(movieScreeningTable, this.MovieScreeningListView);

            // Fill Movies list view.
            ListViewHelper.ListViewHeaders(movieTable, this.MovieListView, 2);
            ListViewHelper.ListViewData(movieTable, this.MovieListView, 2);
            ListViewHelper.ListViewColumnAutoSize(movieTable, this.MovieListView, 2);

            // Fill Showtimes list view.
            ListViewHelper.ListViewHeaders(showtimeTable, this.ShowtimeListView);
            ListViewHelper.ListViewData(showtimeTable, this.ShowtimeListView);
            ListViewHelper.ListViewColumnAutoSize(showtimeTable, this.ShowtimeListView);

            // Fill Screening rooms list view.
            ListViewHelper.ListViewHeaders(screeningRoomTable, this.ScreeningRoomListView, 2);
            ListViewHelper.ListViewData(screeningRoomTable, this.ScreeningRoomListView, 2);
            ListViewHelper.ListViewColumnAutoSize(screeningRoomTable, this.ScreeningRoomListView, 2);
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

        private void MovieScreeningListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MovieScreeningListView.SelectedItems.Count > 0)
            {
                int index = 0;

                this.movieScreeningInfo = ListViewHelper.GetSelectedRow(this.MovieScreeningListView);

                foreach (TextBox textBox in this.textBoxList)
                {
                    textBox.Text = this.movieScreeningInfo[index];
                    index++;
                }

                this.errorLabel.Visible = false;
                this.modifyFirstClick = true;

                ModifyFormHelper.ButtonEnabler(this.buttonList, true);
                ModifyFormHelper.TextBoxEnabler(this.textBoxList, false);
                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            }
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

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);
            ModifyFormHelper.TextBoxEnabler(this.textBoxList, true);
            ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            ModifyFormHelper.ClearSelection(this.textBoxList);

            ListViewHelper.UnselectRow(this.MovieScreeningListView);
            ListViewHelper.UnselectRow(this.MovieListView);
            ListViewHelper.UnselectRow(this.ShowtimeListView);
            ListViewHelper.UnselectRow(this.ScreeningRoomListView);
        }

        // WIP need more validations to prevent overlapping.
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool validMovieID = true;
            bool validShowtimeID = true;
            bool validScreeningRoomID = true;

            this.errorLabel.Text = string.Empty;

            if (!UserInputValidation.NumericValidationCheck(this.movieIDTextBox))
            {
                validMovieID = false;
                this.errorLabel.Text += "\n*MovieID requires only numeric values";
            }

            if (!UserInputValidation.NumericValidationCheck(this.showtimeIDTextBox))
            {
                validMovieID = false;
                this.errorLabel.Text += "\n*ShowtimeID requires only numeric values";
            }

            if (!UserInputValidation.NumericValidationCheck(this.screeningRoomIDTextBox))
            {
                validMovieID = false;
                this.errorLabel.Text += "\n*RoomID requires only numeric values";
            }

            if (validMovieID && validShowtimeID && validScreeningRoomID)
            {
                this.movieInfoBridgeTableAdapter.AddMovieScreening(int.Parse(this.movieIDTextBox.Text), int.Parse(this.showtimeIDTextBox.Text), int.Parse(this.screeningRoomIDTextBox.Text));

                this.errorLabel.Visible = false;

                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                ModifyFormHelper.ClearSelection(this.textBoxList);

                ListViewHelper.ListViewData(this.movieInfoBridgeTableAdapter.GetData(), this.MovieListView);
            }
            else
            {
                this.errorLabel.Visible = true;
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
