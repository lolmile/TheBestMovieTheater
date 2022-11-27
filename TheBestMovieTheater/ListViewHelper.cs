using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestMovieTheater
{
    internal static class ListViewHelper
    {
        public static void ListViewHeaders(DataTable dataTable, ListView listView)
        {
            int columnCount = dataTable.Columns.Count;

            for (int column = 0; column < columnCount; column++)
            {
                listView.Columns.Add(dataTable.Columns[column].ToString());
            }
        }

        public static void ListViewData(DataTable dataTable, ListView listView)
        {
            ListViewItem dataItems;
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;
            string[] dataArray = new string[columnCount];

            for (int row = 0; row < rowCount; row++)
            {
                int counter = row;

                for (int column = 0; column < columnCount; column++)
                {
                    dataArray[column] = dataTable.Rows[counter][column].ToString();
                }

                dataItems = new ListViewItem(dataArray);
                listView.Items.Add(dataItems);
            }
        }
    }
}
