// <copyright file="UserInputValidation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System.Drawing;
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
        /// <returns>Empty textbox returns 0 for fail. Otherwise returns 1 for success.</returns>
        public static int EmptyFieldValidationCheck(TextBox textBoxValidation)
        {
            if (textBoxValidation.Text == string.Empty)
            {
                textBoxValidation.BackColor = Color.MistyRose;
                return 0;
            }

            textBoxValidation.BackColor = default;
            return 1;
        }

        /// <summary>
        /// Checks that the ListView does not contain the exact contents of the textbox.
        /// </summary>
        /// <param name="listViewData">Listview required for validation.</param>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Exact match returns 0 for fail. Otherwise returns 1 for success. </returns>
        public static int DuplicateValidationCheck(ListView listViewData, TextBox textBoxValidation)
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

                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Checks the textbox to validate that all inputs are numeric values.
        /// </summary>
        /// <param name="textBoxValidation">Textbox to be validated.</param>
        /// <returns>Non numeric values found returns 0 for fail. Otherwise returns 1 for success.</returns>
        public static int NumericValidationCheck(TextBox textBoxValidation)
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

                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Checks that the start date is before the end date.
        /// </summary>
        /// <param name="start">DateTimePicker holding the start date.</param>
        /// <param name="end">DateTimePicker holding the end date.</param>
        /// <returns>Returns 0 for fail if the end date is before or equal to the start date. Otherwise returns 1 for success.</returns>
        public static int DateTimeValidationCheck(DateTimePicker start, DateTimePicker end)
        {
            if (start.Value < end.Value)
            {
                return 1;
            }

            return 0;
        }
    }
}
