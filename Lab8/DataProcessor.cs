using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab8
{
    public class DataProcessor
    {
        public DataTable Table { get; private set; } = new DataTable();

        public void LoadDataFromFile(string filePath)
        {
            Table.Clear();
            Table.Columns.Clear();

            string[] lines = File.ReadAllLines(filePath);
            string[] headers = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < headers.Length; i++)
                Table.Columns.Add($"Column {i + 1}");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Table.Rows.Add(parts);
            }
        }

        public void Sort(int columnIndex, string sortOrder, string sortType)
        {
            var rows = Table.AsEnumerable().ToList();
            IEnumerable<DataRow> sortedRows;

            bool ascending = sortOrder == "По алфавиту";

            if (sortType == "\"как числа\"")
            {
                sortedRows = ascending
                    ? rows.OrderBy(r => TryParseDouble(r[columnIndex].ToString()))
                    : rows.OrderByDescending(r => TryParseDouble(r[columnIndex].ToString()));
            }
            else
            {
                sortedRows = ascending
                    ? rows.OrderBy(r => r[columnIndex].ToString())
                    : rows.OrderByDescending(r => r[columnIndex].ToString());
            }

            var newTable = Table.Clone();
            foreach (var row in sortedRows)
                newTable.ImportRow(row);

            Table = newTable;
        }

        private double TryParseDouble(string input)
        {
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double result)
                ? result
                : double.MinValue;
        }


        public void TransformText(int columnIndex, string transformation)
        {
            foreach (DataRow row in Table.Rows)
            {
                string value = row[columnIndex].ToString();
                row[columnIndex] = transformation == "К верхнему регистру"
                    ? value.ToUpper()
                    : value.ToLower();
            }
        }

        public bool IsColumnNumeric(int columnIndex)
        {
            string firstValue = Table.Rows[0][columnIndex].ToString();
            return double.TryParse(firstValue, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }
    }
}
