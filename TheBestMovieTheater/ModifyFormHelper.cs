// <copyright file="ModifyFormHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Holds helpful methods for Modify forms.
    /// </summary>
    internal static class ModifyFormHelper
    {
        /// <summary>
        /// Resets all the textbox values to an string.Empty and resets the buttons to forms default value.
        /// </summary>
        /// <param name="textBoxList">List of textboxes to be modified.</param>
        /// <param name="buttonList">List of buttons to be modified.</param>
        public static void ClearSelection(List<TextBox> textBoxList, List<Button> buttonList)
        {
            foreach (TextBox textBox in textBoxList)
            {
                textBox.Text = string.Empty;
            }

            foreach (Button button in buttonList)
            {
                if (button.Name.Contains("Add"))
                {
                    button.Enabled = true;
                }
                else
                {
                    button.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Reset TextBox backcolor to default.
        /// </summary>
        /// <param name="textBoxList">List of textboxes to be modified.</param>
        public static void ResetTextBoxBackColor(List<TextBox> textBoxList)
        {
            foreach (TextBox textBox in textBoxList)
            {
                if (!textBox.Name.Contains("ID"))
                {
                    textBox.BackColor = default;
                }
            }
        }

        /// <summary>
        /// Enables or disables textboxes depending on parameter.
        /// </summary>
        /// <param name="textBoxList">List of text boxes to modify.</param>
        /// <param name="isEnabled">Determine if textboxes are enabled. </param>
        public static void TextBoxEnabler(List<TextBox> textBoxList, bool isEnabled)
        {
            if (isEnabled)
            {
                foreach (TextBox textBox in textBoxList)
                {
                    if (!textBox.Name.Contains("ID"))
                    {
                        textBox.Enabled = true;
                    }
                }
            }
            else
            {
                foreach (TextBox textBox in textBoxList)
                {
                    if (!textBox.Name.Contains("ID"))
                    {
                        textBox.Enabled = false;
                    }
                }
            }
        }
    }
}
