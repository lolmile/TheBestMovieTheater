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

        // TODO WIP
        public static bool EmptyFieldCheck(TextBox textBoxValidation)
        {
            if (textBoxValidation.Text == string.Empty)
            {
                textBoxValidation.BackColor = Color.MistyRose;
                return false;
            }
            else
            {
                textBoxValidation.BackColor = Color.White;
                return true;
            }
        }

        public static int StringValidationCheck(TextBox[] textBoxValidation)
        {
            bool valid;
            int validCounter = 0;

            return validCounter;
        }

        public static int NumericValidationCheck(TextBox[] textBoxValidation)
        {
            bool valid;
            int validCounter = 0;

            for (int arrayIndex = 0; arrayIndex < textBoxValidation.Length; arrayIndex++)
            {
                valid = true;

                for (int stringIndex = 0; stringIndex < textBoxValidation[arrayIndex].Text.Length; stringIndex++)
                {
                    if (!char.IsDigit(textBoxValidation[arrayIndex].Text, arrayIndex))
                    {
                        textBoxValidation[arrayIndex].BackColor = Color.MistyRose;

                        stringIndex = textBoxValidation[arrayIndex].Text.Length;

                        valid = false;
                    }
                }

                if (valid)
                {
                    textBoxValidation[arrayIndex].BackColor = Color.White;
                    validCounter++;
                }
            }

            if (validCounter != textBoxValidation.Length)
            {
                return validCounter;
            }

            return validCounter;
        }
    }
}
