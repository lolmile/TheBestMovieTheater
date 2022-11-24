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
                    // ClientListForm clientList = new ClientListForm();
                    // clientList.ShowDialog();

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;

                case 1:
                    // TicketSalesForm movieSalesForm = new TicketSalesForm("Movies");
                    // movieSalesForm.ShowDialog();

                    // For testing
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;

                case 2:
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
                    MovieModifyForm movieModifyForm = new MovieModifyForm();
                    movieModifyForm.Show();
                    this.Close();

                    // For testing.
                    // this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    // MessageBox.Show(this.modifySelection);
                    break;

                case 1:
                    // ManagerModifyForm modifyRoomForm = new ManagerModifyForm("Rooms");
                    // modifyRoomForm.ShowDialog();

                    // For testing.
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;

                case 2:
                    // ManagerModifyForm modifyShowtimeForm = new ManagerModifyForm("Showtimes");
                    // modifyShowtimeForm.ShowDialog();

                    // For testing.
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;

                case 3:
                    // ManagerModifyForm modifyPriceForm = new ManagerModifyForm("Prices");
                    // modifyPriceForm.ShowDialog();

                    // For testing.
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
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
