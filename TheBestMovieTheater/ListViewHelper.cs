﻿// <copyright file="ListViewHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Data;
    using System.Data.Common;
    using System.Windows.Forms;

    /// <summary>
    /// A helper class containing methods for ListView objects.
    /// </summary>
    internal static class ListViewHelper
    {
        /// <summary>
        /// Inserts column headers into the ListView.
        /// </summary>
        /// <param name="dataTable">Datatable to insert into ListView.</param>
        /// <param name="listView">ListView object to insert data into.</param>
        public static void ListViewHeaders(DataTable dataTable, ListView listView)
        {
            int columnCount = dataTable.Columns.Count;

            for (int column = 0; column < columnCount; column++)
            {
                listView.Columns.Add(dataTable.Columns[column].ToString());
            }
        }

        /// <summary>
        /// Inserts data into ListView.
        /// </summary>
        /// <param name="dataTable">Datatable to insert into ListView.</param>
        /// <param name="listView">ListView object to insert data into.</param>
        public static void ListViewData(DataTable dataTable, ListView listView)
        {
            ListViewItem dataItems;
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;
            string[] dataArray = new string[columnCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    dataArray[column] = dataTable.Rows[row][column].ToString();
                }

                dataItems = new ListViewItem(dataArray);
                listView.Items.Add(dataItems);
            }
        }

        public static void ListViewColumnAutoSize(DataTable dataTable, ListView listView)
        {
            int headerLength;
            int rowLength;
            int columnCount = dataTable.Columns.Count;
            int rowCount = dataTable.Rows.Count;

            for (int column = 0; column < columnCount; column++)
            {
                headerLength = listView.Columns[column].Text.Length;

                rowLength = 0;

                for (int row = 0; row < rowCount; row++)
                {
                    if (rowLength < listView.Items[row].SubItems[column].Text.Length)
                    {
                        rowLength = listView.Items[row].SubItems[column].Text.Length;
                    }
                }

                if (headerLength > rowLength)
                {
                    listView.Columns[column].Width = -2;
                }
                else
                {
                    listView.Columns[column].Width = -1;
                }
            }
        }
    }
}
