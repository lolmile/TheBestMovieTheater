// <copyright file="ModifyPriceForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    /// <summary>
    /// This Form is to modify the prices of tickets from the database.
    /// </summary>
    public partial class ModifyPriceForm : Form
    {
        /// <summary>
        /// SQL connection string.
        /// </summary>
        private readonly SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPriceForm"/> class.
        /// </summary>
        public ModifyPriceForm()
        {
            this.InitializeComponent();
            this.BindPrices();
        }

        /// <summary>
        /// Bind the prices from the database to the labels.
        /// </summary>
        private void BindPrices()
        {
            List<string> priceList = new List<string>();
            string[] priceArray;

            this.conn.Open();

            SqlCommand cmd = new SqlCommand("Select Price From Price", this.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    priceList.Add(dr[0].ToString());
                }
            }
            finally
            {
                dr.Close();
                this.conn.Close();
            }

            priceArray = priceList.ToArray();

            this.childPriceLabel.Text = priceArray[0] + "$";
            this.adultPriceLabel.Text = priceArray[1] + "$";
            this.studentPriceLabel.Text = priceArray[2] + "$";
            this.elderPriceLabel.Text = priceArray[3] + "$";
        }

        /// <summary>
        /// Updates The prices of ticket with the input from the textBoxes.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            decimal childNewPrice = 0;
            decimal adultNewPrice = 0;
            decimal studentNewPrice = 0;
            decimal elderNewPrice = 0;

            try
            {
               childNewPrice = decimal.Parse(this.newChildPriceMaskedTextBox.Text);
            }
            catch (Exception ex) { }

            if (childNewPrice != 0)
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Price SET Price ='" + childNewPrice + "' WHERE AgeGroup = 'Child(3-13)'", this.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    this.conn.Close();
                }

                this.BindPrices();
            }

            try
            {
                adultNewPrice = decimal.Parse(this.newAdultPriceMaskedTextBox.Text);
            }
            catch (Exception ex) { }

            if (adultNewPrice != 0)
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Price SET Price ='" + adultNewPrice + "' WHERE AgeGroup = 'Adult(14-64)'", this.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    this.conn.Close();
                }

                this.BindPrices();
            }

            try
            {
                studentNewPrice = decimal.Parse(this.newStudentPriceMaskedTextBox.Text);
            }
            catch (Exception ex) { }

            if (studentNewPrice != 0)
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Price SET Price ='" + studentNewPrice + "' WHERE AgeGroup = 'Student'", this.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    this.conn.Close();
                }

                this.BindPrices();
            }

            try
            {
                elderNewPrice = decimal.Parse(this.newElderPriceMaskedTextBox.Text);
            }
            catch (Exception ex) { }

            if (elderNewPrice != 0)
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Price SET Price ='" + elderNewPrice + "' WHERE AgeGroup = 'Elder(65+)'", this.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    this.conn.Close();
                }

                this.BindPrices();
            }

            this.newChildPriceMaskedTextBox.Text = string.Empty;
            this.newAdultPriceMaskedTextBox.Text = string.Empty;
            this.newStudentPriceMaskedTextBox.Text = string.Empty;
            this.newElderPriceMaskedTextBox.Text = string.Empty;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
