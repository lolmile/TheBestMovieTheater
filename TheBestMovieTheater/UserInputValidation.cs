// <copyright file="UserInputValidation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// Holds methods for user input validation.
    /// </summary>
    internal static class UserInputValidation
    {
        /// <summary>
        /// Restricts key input to numeric values [0-9].
        /// </summary>
        /// <param name="sender">The key that was pressed.</param>
        /// <param name="e">Additional event arguments.</param>
        public static void DigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Check the textbox to ensure the field is not empty.
        /// </summary>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Returns false if the textbox is empty. Otherwise returns true.</returns>
        public static bool EmptyFieldValidationCheck(TextBox textBoxValidation)
        {
            if (textBoxValidation.Text == string.Empty)
            {
                textBoxValidation.BackColor = Color.MistyRose;
                return false;
            }

            textBoxValidation.BackColor = default;
            return true;
        }

        /// <summary>
        /// Checks that the ListView does not contain the exact contents of the textbox.
        /// </summary>
        /// <param name="listViewData">Listview required for validation.</param>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Returns false if duplicate string is found or textbox is empty. Otherwise returns true. </returns>
        public static bool DuplicateValidationCheck(ListView listViewData, TextBox textBoxValidation)
        {
            bool valid = true;
            ListViewItem item = listViewData.FindItemWithText(textBoxValidation.Text);

            if (textBoxValidation.Text == string.Empty || item != null)
            {
                textBoxValidation.BackColor = Color.MistyRose;

                valid = false;
            }

            if (valid)
            {
                textBoxValidation.BackColor = default;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks that the ListView does not contain the exact contents of the textbox.
        /// </summary>
        /// <param name="listViewData">Listview required for validation.</param>
        /// <param name="dateTimePickerValidation">DateTimePicker to be validated.</param>
        /// <returns>Returns false if duplicate string is found or textbox is empty. Otherwise returns true. </returns>
        public static bool DuplicateValidationCheck(ListView listViewData, DateTimePicker dateTimePickerValidation)
        {
            bool valid = true;
            ListViewItem item = listViewData.FindItemWithText(dateTimePickerValidation.Text);

            if (dateTimePickerValidation.Text == string.Empty || item != null)
            {
                dateTimePickerValidation.BackColor = Color.MistyRose;

                valid = false;
            }

            if (valid)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks the textbox to validate that all inputs are numeric values.
        /// </summary>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Returns false if non numeric character is found or the textbox is empty. Otherwise returns true.</returns>
        public static bool NumericValidationCheck(TextBox textBoxValidation)
        {
            bool valid = true;

            if (textBoxValidation.Text != string.Empty)
            {
                foreach (char character in textBoxValidation.Text)
                {
                    if (!char.IsNumber(character))
                    {
                        textBoxValidation.BackColor = Color.MistyRose;

                        valid = false;

                        break;
                    }
                }
            }
            else
            {
                textBoxValidation.BackColor = Color.MistyRose;

                valid = false;
            }

            if (valid)
            {
                textBoxValidation.BackColor = default;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks the textbox to validate that all inputs are numeric values also checking the length of the field.
        /// </summary>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <param name="requiredLength">Required length of the field to succeed.</param>
        /// <returns>Returns false if non numeric character is found or the textbox is empty or the required length is not met. Otherwise returns true.</returns>
        public static bool NumericValidationCheck(TextBox textBoxValidation, int requiredLength)
        {
            bool valid = true;

            if (textBoxValidation.Text != string.Empty && textBoxValidation.Text.Length == requiredLength)
            {
                foreach (char character in textBoxValidation.Text)
                {
                    if (!char.IsNumber(character))
                    {
                        textBoxValidation.BackColor = Color.MistyRose;

                        valid = false;

                        break;
                    }
                }
            }
            else
            {
                textBoxValidation.BackColor = Color.MistyRose;

                valid = false;
            }

            if (valid)
            {
                textBoxValidation.BackColor = default;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks that the start date is before the end date.
        /// </summary>
        /// <param name="start">DateTimePicker holding the start date.</param>
        /// <param name="end">DateTimePicker holding the end date.</param>
        /// <returns>Returns false if the end date is before or equal to the start date or the start date is before today. Otherwise return true.</returns>
        public static bool DateTimeValidationCheck(DateTimePicker start, DateTimePicker end)
        {
            if (start.Value >= end.Value || start.Value < DateTime.Today)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks that the ListView does not contain the exact contents of the textbox.
        /// </summary>
        /// <param name="listViewData">Listview required for validation.</param>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Returns false if duplicate string is found or textbox is empty. Otherwise returns true. </returns>
        public static bool ExistingValidationCheck(ListView listViewData, TextBox textBoxValidation)
        {
            bool valid = true;
            ListViewItem item = listViewData.FindItemWithText(textBoxValidation.Text);

            if (textBoxValidation.Text == string.Empty || item == null)
            {
                textBoxValidation.BackColor = Color.MistyRose;

                valid = false;
            }

            if (valid)
            {
                textBoxValidation.BackColor = default;

                return true;
            }

            return false;
        }
    }
}
