// <copyright file="ManagerMenuForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// ManagerMenuForm contains the design and functions for manager options.
    /// </summary>
    public partial class ManagerMenuForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerMenuForm"/> class.
        /// Default constructor for ManagerMenuForm.
        /// </summary>
        public ManagerMenuForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button click opens a form for the selected value.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ViewButton_Click(object sender, EventArgs e)
        {
            switch (this.viewsComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();

                    ConsultClientForm clientList = new ConsultClientForm();
                    clientList.ShowDialog();

                    this.Show();

                    break;

                case 1:
                    this.Hide();

                    TicketInfoForm ticketInfoForm = new TicketInfoForm();
                    ticketInfoForm.ShowDialog();

                    this.Show();

                    break;

                default:
                    MessageBox.Show("Please select a viewing option from the drop down menu.", "Warning");
                    break;
            }
        }

        /// <summary>
        /// Button click opens the ManagerModifyForm passing the modify selection to retreive desired list.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            switch (this.modifyComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();

                    MovieScreeningsModifyForm movieScreeningsModifyForm = new MovieScreeningsModifyForm();
                    movieScreeningsModifyForm.ShowDialog();

                    this.Show();

                    break;

                case 1:
                    this.Hide();

                    MovieModifyForm movieModifyForm = new MovieModifyForm();
                    movieModifyForm.ShowDialog();

                    this.Show();

                    break;

                case 2:
                    this.Hide();

                    ScreeningRoomModifyForm roomModifyForm = new ScreeningRoomModifyForm();
                    roomModifyForm.ShowDialog();

                    this.Show();
                    break;

                case 3:
                    this.Hide();

                    ShowtimeModifyForm showtimeModifyForm = new ShowtimeModifyForm();
                    showtimeModifyForm.ShowDialog();

                    this.Show();
                    break;

                case 4:
                    this.Hide();

                    ModifyPriceForm modifyPriceForm = new ModifyPriceForm();
                    modifyPriceForm.ShowDialog();

                    this.Show();
                    break;

                default:
                    MessageBox.Show("Please select a modifying option from the drop down menu.", "Warning");
                    break;
            }
        }

        /// <summary>
        /// Button click closes the current form program and opens the login form.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();

            this.Close();
        }
    }
}
