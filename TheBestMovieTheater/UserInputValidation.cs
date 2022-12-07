// <copyright file="UserInputValidation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Reflection;
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

            if (item == null)
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
        /// Validates user input to make sure no movie screening is overlapping.
        /// </summary>
        /// <param name="inputData">List of TextBoxes containing user input information.</param>
        /// <param name="validationData">Data table containing validation information.</param>
        /// <param name="showtimeTable">Showtime table containing all the showtimes available.</param>
        /// <returns>Returns false if user input overlaps existing information. Otherwise returns true.</returns>
        public static bool ScreeningOverlapValidationCheck(List<TextBox> inputData, DataTable validationData, DataTable showtimeTable)
        {
            List<int> validationIndices = new List<int>();

            TimeSpan filmLength = TimeSpan.Zero;

            string formattedDate = string.Empty;

            int validationShowtimeID = -1;
            int nextShowtimeID = -1;

            int inputMovieID = int.Parse(inputData[1].Text);
            int inputShowtimeID = int.Parse(inputData[2].Text);
            int inputRoomID = int.Parse(inputData[3].Text);

            // Loops the data adding indexes where MovieID & RoomID matches input IDs.
            for (int dataIndex = 0; dataIndex < validationData.Rows.Count; dataIndex++)
            {
                if (int.Parse(validationData.Rows[dataIndex][0].ToString()) == inputMovieID && int.Parse(validationData.Rows[dataIndex][2].ToString()) == inputRoomID)
                {
                    validationIndices.Add(dataIndex);
                }
            }

            // If List is empty add index for matching RoomIDs.
            if (validationIndices.Count <= 0)
            {
                for (int dataIndex = 0; dataIndex < validationData.Rows.Count; dataIndex++)
                {
                    if (int.Parse(validationData.Rows[dataIndex][2].ToString()) == inputRoomID)
                    {
                        validationIndices.Add(dataIndex);
                    }
                }
            }

            // If list still empty then room has no showtimes return true.
            if (validationIndices.Count <= 0)
            {
                return true;
            }

            validationIndices.Sort((a, b) => b.CompareTo(a));

            // Loop through Rooms and check if showtime matches user input. If user input is greater get the film length and index of last ShowtimeID.
            foreach (int index in validationIndices)
            {
                if (inputShowtimeID == int.Parse(validationData.Rows[index][1].ToString()))
                {
                    break;
                }

                if (inputShowtimeID > int.Parse(validationData.Rows[index][1].ToString()))
                {
                    filmLength = TimeSpan.FromMinutes(double.Parse(validationData.Rows[index][4].ToString()));

                    validationShowtimeID = int.Parse(validationData.Rows[index][1].ToString());

                    break;
                }
            }

            if (filmLength > TimeSpan.Zero)
            {
                formattedDate = RoomAvailableTime(filmLength, validationShowtimeID, validationData);
                nextShowtimeID = NextShowtimeSlot(formattedDate, showtimeTable);
            }

            if (nextShowtimeID > 0)
            {
                if (inputShowtimeID >= nextShowtimeID)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates the next available showtime by taking the start showtime, film length, and clean up time. Rounding up to the nearest quarter hour.
        /// </summary>
        /// <param name="movieTime">Timespan of the movie length.</param>
        /// <param name="showtimeID">User input for showtimeID.</param>
        /// <param name="dataTable">ShowtimeData used to validate.</param>
        /// <returns>Returns a string variable of the room availbility time.</returns>
        private static string RoomAvailableTime(TimeSpan movieTime, int showtimeID, DataTable dataTable)
        {
            string formattedRoomAvailability = string.Empty;

            TimeSpan roundUp = TimeSpan.FromMinutes(15);
            TimeSpan cleanUpTime = TimeSpan.FromMinutes(30);
            TimeSpan showtime;
            TimeSpan totalTime;

            DateTime roomClearTime;
            DateTime roomAvailability;

            // Calculate room availability rounding to the nearest quarter hour(15min).
            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                if (dataTable.Rows[index][1].ToString() == showtimeID.ToString())
                {
                    showtime = TimeSpan.Parse(dataTable.Rows[index][5].ToString());
                    totalTime = movieTime + showtime + cleanUpTime;

                    // If total time is past 23:59 then set total time to 00:00.
                    if (totalTime >= TimeSpan.FromDays(1))
                    {
                        totalTime = TimeSpan.FromHours(0);
                    }

                    roomClearTime = DateTime.Parse(totalTime.ToString());
                    roomAvailability = new DateTime((roomClearTime.Ticks + roundUp.Ticks - 1) / roundUp.Ticks * roundUp.Ticks, roomClearTime.Kind);

                    formattedRoomAvailability = roomAvailability.TimeOfDay.ToString().Substring(0, 5);

                    break;
                }
            }

            return formattedRoomAvailability;
        }

        /// <summary>
        /// Receives a formatted timespan and showtime table and determines the ID for the next available showtime.
        /// </summary>
        /// <param name="roomOpenTime">String containing a formatted TimeSpan of the room availability.</param>
        /// <param name="dataTable">Data table containing showtime IDs.</param>
        /// <returns>Returns the next available showtime ID.</returns>
        private static int NextShowtimeSlot(string roomOpenTime, DataTable dataTable)
        {
            int availableShowtimeID = -1;

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                if (dataTable.Rows[index][1].ToString() == roomOpenTime)
                {
                    availableShowtimeID = index;
                    break;
                }
            }

            return availableShowtimeID;
        }
    }
}
