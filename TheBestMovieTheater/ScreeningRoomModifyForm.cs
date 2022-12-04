// <copyright file="ScreeningRoomModifyForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// ScreeningRoomModifyForm contains the design and functions for screening room information.
    /// </summary>
    public partial class ScreeningRoomModifyForm : Form
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
        /// String array to hold the information of the selected screening room.
        /// </summary>
        private string[] roomInfo;

        /// <summary>
        /// Holds boolean value to determine the first click of the modify button.
        /// </summary>
        private bool modifyFirstClick = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreeningRoomModifyForm"/> class.
        /// Default constructor for ScreeningRoomModifyForm.
        /// </summary>
        public ScreeningRoomModifyForm()
        {
            this.InitializeComponent();

            this.capacityTextBox.KeyPress += new KeyPressEventHandler(UserInputValidation.DigitTextBox_KeyPress);

            this.textBoxList = new List<TextBox> { this.roomIDTextBox, this.roomNumberTextBox, this.capacityTextBox };
            this.buttonList = new List<Button> { this.AddButton, this.ModifyButton, this.DeleteButton };

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);
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

        private void ScreeningRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ScreeningRoomListView.SelectedItems.Count > 0)
            {
                int index = 0;

                this.roomInfo = ListViewHelper.GetSelectedRow(this.ScreeningRoomListView);

                foreach (TextBox textBox in this.textBoxList)
                {
                    textBox.Text = this.roomInfo[index];
                    index++;
                }

                this.errorLabel.Visible = false;
                this.modifyFirstClick = true;

                ModifyFormHelper.ButtonEnabler(this.buttonList, true);
                ModifyFormHelper.TextBoxEnabler(this.textBoxList, false);
                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool validRoom = true;
            bool validCapacity = true;

            this.errorLabel.Text = string.Empty;

            if (!UserInputValidation.DuplicateValidationCheck(this.ScreeningRoomListView, this.roomNumberTextBox))
            {
                validRoom = false;
                this.errorLabel.Text = "*Room must be unique";
            }

            if (!UserInputValidation.NumericValidationCheck(this.capacityTextBox))
            {
                validCapacity = false;
                this.errorLabel.Text += "\n*Capacity requires numeric values";
            }

            if (validRoom && validCapacity)
            {
                this.screeningRoomTableAdapter.AddScreeningRoom(this.roomNumberTextBox.Text, int.Parse(this.capacityTextBox.Text));

                this.errorLabel.Visible = false;

                ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                ModifyFormHelper.ClearSelection(this.textBoxList);

                ListViewHelper.ListViewData(this.screeningRoomTableAdapter.GetData(), this.ScreeningRoomListView);
            }
            else
            {
                this.errorLabel.Visible = true;
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            bool validRoom = true;
            bool validCapacity = true;

            this.errorLabel.Text = string.Empty;

            if (this.modifyFirstClick)
            {
                this.modifyFirstClick = false;
                this.DeleteButton.Enabled = false;

                ModifyFormHelper.TextBoxEnabler(this.textBoxList, true);
            }
            else
            {
                if (!UserInputValidation.DuplicateValidationCheck(this.ScreeningRoomListView, this.roomNumberTextBox))
                {
                    validRoom = false;
                    this.errorLabel.Text = "*Room must be unique";
                }

                if (!UserInputValidation.NumericValidationCheck(this.capacityTextBox))
                {
                    validCapacity = false;
                    this.errorLabel.Text += "\n*Capacity requires numeric values";
                }

                if (validRoom && validCapacity)
                {
                    this.screeningRoomTableAdapter.UpdateScreeningRoom(this.roomNumberTextBox.Text, int.Parse(this.capacityTextBox.Text), int.Parse(this.roomIDTextBox.Text));

                    this.errorLabel.Visible = false;
                    this.modifyFirstClick = true;

                    ModifyFormHelper.ButtonEnabler(this.buttonList, false);
                    ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
                    ModifyFormHelper.ClearSelection(this.textBoxList);

                    ListViewHelper.ListViewData(this.screeningRoomTableAdapter.GetData(), this.ScreeningRoomListView);
                }
                else
                {
                    this.errorLabel.Visible = true;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;
            this.modifyFirstClick = true;

            ModifyFormHelper.ButtonEnabler(this.buttonList, false);
            ModifyFormHelper.TextBoxEnabler(this.textBoxList, true);
            ModifyFormHelper.ResetTextBoxBackColor(this.textBoxList);
            ModifyFormHelper.ClearSelection(this.textBoxList);

            ListViewHelper.UnselectRow(this.ScreeningRoomListView);
        }
    }
}
