// <copyright file="UserInputValidation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal static class UserInputValidation
    {
        public static void DigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static int EmptyFieldValidationCheck(TextBox textBoxValidation)
        {
            if (textBoxValidation.Text == string.Empty)
            {
                textBoxValidation.BackColor = Color.MistyRose;
                return 0;
            }

            textBoxValidation.BackColor = Color.White;
            return 1;
        }

        public static int DuplicateValidationCheck(ListView listViewData ,TextBox textBoxValidation)
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
                textBoxValidation.BackColor = Color.White;

                return 1;
            }

            return 0;
        }

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
                textBoxValidation.BackColor = Color.White;

                return 1;
            }

            return 0;
        }

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
