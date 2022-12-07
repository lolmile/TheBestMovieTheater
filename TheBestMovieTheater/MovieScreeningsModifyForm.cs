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

    /// <summary>
    /// Contains the design and functionality for movie screenings.
    /// </summary>
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
        /// List of list views.
        /// </summary>
        private readonly List<ListView> listViewList;

        /// <summary>
        /// List of data tables.
        /// </summary>
        private readonly List<DataTable> dataTableList;

        /// <summary>
        /// Datatable to hold movie screening view information.
        /// </summary>
        private DataTable vMovieBridgeTable;

        /// <summary>
        /// Datatable to hold moviescreening table information.
        /// </summary>
        private DataTable movieScreeningTable;

        /// <summary>
        /// Datatable to hold movie table information.
        /// </summary>
        private DataTable movieTable;

        /// <summary>
        /// Datatable to hold showtime table information.
        /// </summary>
        private DataTable showtimeTable;

        /// <summary>
        /// Datatable to hold screening room table information.
        /// </summary>
        private DataTable screeningRoomTable;

        /// <summary>
        /// String array to hold the movies screening information.
        /// </summary>
        private string[] movieScreeningInfo;

        /// <summary>
        /// Holds boolean value to determine the first click of the modify button.
        /// </summary>
        private bool modifyFirstClick = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieScreeningsModifyForm"/> class.
        /// Default constructor for MovieScreeningModifyForm.
        /// </summary>
        public MovieScreeningsModifyForm()
        {
            this.InitializeComponent();

            this.movieIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.showtimeIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);
            this.screeningRoomIDTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);

            this.vMovieBridgeTable = this.vManager_ScreeningsTableAdapter.GetData();
            this.movieScreeningTable = this.movieInfoBridgeTableAdapter.GetData();
            this.movieTable = this.movieTableAdapter.GetData();
            this.showtimeTable = this.showtimeTableAdapter.GetData();
            this.screeningRoomTable = this.screeningRoomTableAdapter.GetData();

            this.textBoxList = new List<TextBox> { this.movieScreeningIDTextBox, this.movieIDTextBox, this.showtimeIDTextBox, this.screeningRoomIDTextBox };
            this.buttonList = new List<Button> { this.AddButton, this.ModifyButton, this.DeleteButton };
            this.listViewList = new List<ListView> { this.MovieListView, this.ShowtimeListView, this.ScreeningRoomListView };
            this.dataTableList = new List<DataTable> { this.movieTable, this.showtimeTable, this.screeningRoomTable };
        }

        /// <summary>
        /// Fills listviews with data on form load.
        /// </summary>
        /// <param name="sender">The form that was loaded.</param>
        /// <param name="e">Additional event arguments.</param>
        private void MovieScreeningsModifyForm_Load(object sender, EventArgs e)
        {
            ModifyFormHelper.ButtonEnabler(this.buttonList, false);

            // Fill Movie Screenings list view.
            ListViewHelper.ListViewHeaders(this.movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewData(this.movieScreeningTable, this.MovieScreeningListView);
            ListViewHelper.ListViewColumnAutoSize(this.movieScreeningTable, this.MovieScreeningListView);

            // Fill Movies list view.
            ListViewHelper.ListViewHeaders(this.movieTable, this.MovieListView, 2);
            ListViewHelper.ListViewData(this.movieTable, this.MovieListView, 2);
            ListViewHelper.ListViewColumnAutoSize(this.movieTable, this.MovieListView, 2);

            // Fill Showtimes list view.
            ListViewHelper.ListViewHeaders(this.showtimeTable, this.ShowtimeListView);
            ListViewHelper.ListViewData(this.showtimeTable, this.ShowtimeListView);
            ListViewHelper.ListViewColumnAutoSize(this.showtimeTable, this.ShowtimeListView);

            // Fill Screening rooms list view.
            ListViewHelper.ListViewHeaders(this.screeningRoomTable, this.ScreeningRoomListView, 2);
            ListViewHelper.ListViewData(this.screeningRoomTable, this.ScreeningRoomListView, 2);
            ListViewHelper.ListViewColumnAutoSize(this.screeningRoomTable, this.ScreeningRoomListView, 2);
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
        /// Fills textbox with movie screening information when a row is selected.
        /// </summary>
        /// <param name="sender">The listview index that was changed.</param>
        /// <param name="e">Additional event arguments.</param>
        private void MovieScreeningListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MovieScreeningListView.SelectedItems.Count > 0)
            {
                int index = 0;

                this.movieScreeningInfo = ListViewHelper.GetSelectedRow(this.MovieScreeningListView);

                foreach (TextBox textBox in this.textBoxList)
                {
                    textBox.Text = this.movieScreeningInfo[index];

                    if (index < 3)
                    {
                        ListViewHelper.SelectMatchingRow(this.listViewList[index], this.movieScreeningInfo[index + 1]);
                    }

                    index++;
                }

                this.errorLabel.Visible = false;
                this.modifyFirstClick = true;

                ModifyFormHelper.ButtonEnabler(this.buttonList, true);
                ModifyFormHelper.TextBoxReadOnlySkipOne(this.textBoxList, true);
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
            ModifyFormHelper.TextBoxReadOnlySkipOne(this.textBoxList, false);
            ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            ModifyFormHelper.ClearSelection(this.textBoxList);

            ListViewHelper.UnselectRow(this.MovieScreeningListView);
            ListViewHelper.UnselectRow(this.MovieListView);
            ListViewHelper.UnselectRow(this.ShowtimeListView);
            ListViewHelper.UnselectRow(this.ScreeningRoomListView);
        }

        /// <summary>
        /// On button click, add the textbox information to the movie info bridge table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool validMovieID = true;
            bool validShowtimeID = true;
            bool validScreeningRoomID = true;
            bool validTimeSlot = true;

            this.errorLabel.Text = string.Empty;

            // MovieID Validations.
            if (UserInputValidation.ExistingValidationCheck(this.MovieListView, this.movieIDTextBox))
            {
                if (!UserInputValidation.NumericValidationCheck(this.movieIDTextBox))
                {
                    validMovieID = false;
                    this.errorLabel.Text += "\n*MovieID cannot be blank and\n  requires only numeric values";
                }
            }
            else
            {
                validMovieID = false;
                this.errorLabel.Text += "\n*MovieID requires an existing ID";
            }

            // ShowtimeID Validations.
            if (UserInputValidation.ExistingValidationCheck(this.ShowtimeListView, this.showtimeIDTextBox))
            {
                if (!UserInputValidation.NumericValidationCheck(this.showtimeIDTextBox))
                {
                    validShowtimeID = false;
                    this.errorLabel.Text += "\n*ShowtimeID cannot be blank and\n  requires only numeric values";
                }
            }
            else
            {
                validShowtimeID = false;
                this.errorLabel.Text += "\n*ShowtimeID requires an existing ID";
            }

            // ScreeningRoomID Validations.
            if (UserInputValidation.ExistingValidationCheck(this.ScreeningRoomListView, this.screeningRoomIDTextBox))
            {
                if (!UserInputValidation.NumericValidationCheck(this.screeningRoomIDTextBox))
                {
                    validScreeningRoomID = false;
                    this.errorLabel.Text += "\n*RoomID cannot be blank and\n  requires only numeric values";
                }
            }
            else
            {
                validScreeningRoomID = false;
                this.errorLabel.Text += "\n*RoomID requires an existing ID";
            }

            if (validMovieID && validShowtimeID && validScreeningRoomID)
            {
                // Overlapping Request Validation.
                if (!UserInputValidation.ScreeningOverlapValidationCheck(this.textBoxList, this.vMovieBridgeTable, this.showtimeTable))
                {
                    validTimeSlot = false;
                    this.errorLabel.Text += "\n*Invalid input";
                    this.errorLabel.Text += "\n  Room is occupied\n  select another showtime or room";

                    this.showtimeIDTextBox.BackColor = Color.MistyRose;
                    this.screeningRoomIDTextBox.BackColor = Color.MistyRose;

                    this.errorLabel.Visible = true;
                }

                if (validTimeSlot)
                {
                    this.movieInfoBridgeTableAdapter.AddMovieScreening(int.Parse(this.movieIDTextBox.Text), int.Parse(this.showtimeIDTextBox.Text), int.Parse(this.screeningRoomIDTextBox.Text));

                    this.errorLabel.Visible = false;

                    ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                    ModifyFormHelper.ClearSelection(this.textBoxList);

                    ListViewHelper.ListViewData(this.movieInfoBridgeTableAdapter.GetData(), this.MovieScreeningListView);
                }
            }
            else
            {
                this.errorLabel.Visible = true;
            }
        }

        /// <summary>
        /// On button click, modify the list of movie screenings on the MovieBridgeInfo table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            bool validTimeSlot = true;
            bool validMovieID = true;
            bool validShowtimeID = true;
            bool validScreeningRoomID = true;

            this.errorLabel.Text = string.Empty;

            if (this.modifyFirstClick)
            {
                this.modifyFirstClick = false;
                this.DeleteButton.Enabled = false;

                ModifyFormHelper.TextBoxReadOnlySkipOne(this.textBoxList, false);
            }
            else
            {
                // MovieID Validations.
                if (UserInputValidation.ExistingValidationCheck(this.MovieListView, this.movieIDTextBox))
                {
                    if (!UserInputValidation.NumericValidationCheck(this.movieIDTextBox))
                    {
                        validMovieID = false;
                        this.errorLabel.Text += "\n*MovieID cannot be blank and\n  requires only numeric values";
                    }
                }
                else
                {
                    validMovieID = false;
                    this.errorLabel.Text += "\n*MovieID requires an existing ID";
                }

                // ShowtimeID Validations.
                if (UserInputValidation.ExistingValidationCheck(this.ShowtimeListView, this.showtimeIDTextBox))
                {
                    if (!UserInputValidation.NumericValidationCheck(this.showtimeIDTextBox))
                    {
                        validShowtimeID = false;
                        this.errorLabel.Text += "\n*ShowtimeID cannot be blank and\n  requires only numeric values";
                    }
                }
                else
                {
                    validShowtimeID = false;
                    this.errorLabel.Text += "\n*ShowtimeID requires an existing ID";
                }

                // ScreeningRoomID Validations.
                if (UserInputValidation.ExistingValidationCheck(this.ScreeningRoomListView, this.screeningRoomIDTextBox))
                {
                    if (!UserInputValidation.NumericValidationCheck(this.screeningRoomIDTextBox))
                    {
                        validScreeningRoomID = false;
                        this.errorLabel.Text += "\n*RoomID cannot be blank and\n  requires only numeric values";
                    }
                }
                else
                {
                    validScreeningRoomID = false;
                    this.errorLabel.Text += "\n*RoomID requires an existing ID";
                }

                if (validMovieID && validShowtimeID && validScreeningRoomID)
                {
                    // Overlapping Request Validation.
                    if (!UserInputValidation.ScreeningOverlapValidationCheck(this.textBoxList, this.vMovieBridgeTable, this.showtimeTable))
                    {
                        validTimeSlot = false;
                        this.errorLabel.Text += "\n*Invalid input";
                        this.errorLabel.Text += "\n  Room is occupied\n  select another showtime or room";

                        this.showtimeIDTextBox.BackColor = Color.MistyRose;
                        this.screeningRoomIDTextBox.BackColor = Color.MistyRose;

                        this.errorLabel.Visible = true;
                    }

                    if (validTimeSlot)
                    {
                        this.movieInfoBridgeTableAdapter.UpdateMovieScreening(int.Parse(this.movieIDTextBox.Text), int.Parse(this.showtimeIDTextBox.Text), int.Parse(this.screeningRoomIDTextBox.Text), int.Parse(this.screeningRoomIDTextBox.Text));

                        this.errorLabel.Visible = false;

                        ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                        ModifyFormHelper.ClearSelection(this.textBoxList);

                        ListViewHelper.ListViewData(this.movieInfoBridgeTableAdapter.GetData(), this.MovieScreeningListView);
                    }
                }
                else
                {
                    this.errorLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// On button click, delete the selected movie screening from the movie info bridge table in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.movieInfoBridgeTableAdapter.DeleteMovieScreening(int.Parse(this.movieScreeningIDTextBox.Text));

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);
            ModifyFormHelper.TextBoxReadOnly(this.textBoxList, false);
            ModifyFormHelper.ClearSelection(this.textBoxList);

            ListViewHelper.ListViewData(this.movieInfoBridgeTableAdapter.GetData(), this.MovieScreeningListView);
        }
    }
}
