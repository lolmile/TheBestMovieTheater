// <copyright file="ListViewHelper.cs" company="PlaceholderCompany">
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
        /// <param name="dataTable">Data source for the ListView.</param>
        /// <param name="listView">ListView object to modify.</param>
        public static void ListViewHeaders(DataTable dataTable, ListView listView)
        {
            int columnCount = dataTable.Columns.Count;

            for (int column = 0; column < columnCount; column++)
            {
                listView.Columns.Add(dataTable.Columns[column].ToString());
            }
        }

        /// <summary>
        /// Inserts source data into ListView.
        /// </summary>
        /// <param name="dataTable">Data source for the ListView.</param>
        /// <param name="listView">ListView object to modify.</param>
        public static void ListViewData(DataTable dataTable, ListView listView)
        {
            ListViewItem dataItems;
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;
            string[] dataArray = new string[columnCount];

            listView.Items.Clear();

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

        /// <summary>
        /// Auto sizes each column by header size or row size, depending which has the largest length.
        /// </summary>
        /// <param name="dataTable">Data source for the ListView.</param>
        /// <param name="listView">ListView object to modify.</param>
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

        /// <summary>
        /// Gets the values of the selected row from a list view.
        /// </summary>
        /// <param name="listView">List view holding the date.</param>
        /// <returns>Returns a string array for the selected row.</returns>
        public static string[] GetSelectedRow(ListView listView)
        {
            string[] listArray = new string[listView.SelectedItems[0].SubItems.Count];

            for (int i = 0; i < listArray.Length; i++)
            {
                listArray[i] = listView.SelectedItems[0].SubItems[i].Text;
            }

            return listArray;
        }

        /// <summary>
        /// Unselects current row from the listview.
        /// </summary>
        /// <param name="listView">List view holding the row to be unselected.</param>
        public static void UnselectRow(ListView listView)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                listView.SelectedItems[0].Selected = false;
            }
        }
    }
}
