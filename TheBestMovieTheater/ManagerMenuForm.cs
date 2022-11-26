// <copyright file="ManagerMenuForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// ManagerMenuForm Class contains the design and functions for manager options.
    /// </summary>
    public partial class ManagerMenuForm : Form
    {
        /// <summary>
        /// String variable to hold the consult selection from the ConsultComboBox.
        /// </summary>
        private string consultSelection;

        /// <summary>
        /// String variable to hold the modify selection from the ModifyComboBox.
        /// </summary>
        private string modifySelection;

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

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;

                case 1:
                    // ClientListForm clientList = new ClientListForm();
                    // clientList.ShowDialog();

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;

                case 2:
                    // TicketSalesForm movieSalesForm = new TicketSalesForm("Movies");
                    // movieSalesForm.ShowDialog();

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;

                case 3:
                    // TicketSalesForm showtimeSalesForm = new TicketSalesForm("Showtimes");
                    // showtimeSalesForm.ShowDialog();

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
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

                    MovieModifyForm movieModifyForm = new MovieModifyForm();
                    movieModifyForm.ShowDialog();

                    this.Show();

                    break;

                case 1:
                    this.Hide();

                    ScreeningRoomModifyForm roomModifyForm = new ScreeningRoomModifyForm();
                    roomModifyForm.ShowDialog();

                    this.Show();
                    break;

                case 2:
                    this.Hide();

                    ShowtimeModifyForm showtimeModifyForm = new ShowtimeModifyForm();
                    showtimeModifyForm.ShowDialog();

                    this.Show();
                    break;

                case 3:
                    this.Hide();

                    // ManagerModifyForm modifyPriceForm = new ManagerModifyForm("Prices");
                    // modifyPriceForm.ShowDialog();

                    // For testing.
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);

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
