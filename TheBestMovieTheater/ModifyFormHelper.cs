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
    using System.Windows.Shell;

    /// <summary>
    /// Holds helpful methods for Modify forms.
    /// </summary>
    internal static class ModifyFormHelper
    {
        /// <summary>
        /// Resets all the textbox values to string.Empty.
        /// </summary>
        /// <param name="textBoxList">List of textboxes to be modified.</param>
        public static void ClearSelection(List<TextBox> textBoxList)
        {
            foreach (TextBox textBox in textBoxList)
            {
                textBox.Text = string.Empty;
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
                textBox.BackColor = default;
            }
        }

        /// <summary>
        /// Enables or disables textboxes read only property depending on parameter.
        /// </summary>
        /// <param name="textBoxList">List of text boxes to modify.</param>
        /// <param name="isReadOnly">Determine if textboxes are read only. </param>
        public static void TextBoxReadOnly(List<TextBox> textBoxList, bool isReadOnly)
        {
            if (isReadOnly)
            {
                foreach (TextBox textBox in textBoxList)
                {
                    if (!textBox.Name.Contains("ID"))
                    {
                        textBox.ReadOnly = true;
                    }
                }
            }
            else
            {
                foreach (TextBox textBox in textBoxList)
                {
                    if (!textBox.Name.Contains("ID"))
                    {
                        textBox.ReadOnly = false;
                    }
                }
            }
        }

        /// <summary>
        /// Skips first textbox, then enables or disables textboxes read only property depending on parameter.
        /// </summary>
        /// <param name="textBoxList">List of text boxes to modify.</param>
        /// <param name="isReadOnly">Determine if textboxes are read only. </param>
        public static void TextBoxReadOnlySkipOne(List<TextBox> textBoxList, bool isReadOnly)
        {
            if (isReadOnly)
            {
                for (int index = 1; index < textBoxList.Count; index++)
                {
                    textBoxList[index].ReadOnly = true;
                }
            }
            else
            {
                for (int index = 1; index < textBoxList.Count; index++)
                {
                    textBoxList[index].ReadOnly = false;
                }
            }
        }

        /// <summary>
        /// Enables or disables buttons depending on parameter.
        /// </summary>
        /// <param name="buttonList">List of buttons to modify.</param>
        /// <param name="isEnabled">Determine if textboxes are enabled. </param>
        public static void ButtonEnabler(List<Button> buttonList, bool isEnabled)
        {
            if (isEnabled)
            {
                foreach (Button button in buttonList)
                {
                    if (!button.Name.Contains("Add"))
                    {
                        button.Enabled = true;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Button button in buttonList)
                {
                    if (!button.Name.Contains("Add"))
                    {
                        button.Enabled = false;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
            }
        }
    }
}
