using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataSet1 dataset;
        public enum COLUMNS { DRINKID, DRINKNAME, PRICE, STOCK, CATEGORY }

        List<string> csvList = null;

        public Form1()
        {
            InitializeComponent();
            dataset = new DataSet1();
            LoadBtn.Click += LoadBtn_Click;
            AddBtn.Click += button1_Click; // Ensure the event is registered only once
            saveBtn.Click += SaveBtn_Click; // Ensure the event is registered only once
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewDrink();
                DataSourceGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // 절대 경로를 사용하여 CSV 파일을 지정
            string[] fileName = { @"C:\Path\To\Your\CsvFiles\file1.csv", @"C:\Path\To\Your\CsvFiles\file2.csv" };
            csvList = fileName.Where(x => x.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)).ToList();

            try
            {
                GetCSVData(csvList);
                DataSourceGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void GetCSVData(List<string> csvList)
        {
            foreach (var file in csvList)
            {
                var query = File.ReadLines(file, Encoding.Default)
                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.Contains("DrinkName"))
                    .Select(line => line.Split(','))
                    .Select(values => new
                    {
                        DrinkID = values[(int)COLUMNS.DRINKID],
                        DrinkName = values[(int)COLUMNS.DRINKNAME],
                        Price = values[(int)COLUMNS.PRICE],
                        Stock = values[(int)COLUMNS.STOCK],
                        Category = values[(int)COLUMNS.CATEGORY]
                    });

                foreach (var item in query)
                {
                    DataRow row = dataset.Tables["Drink"].NewRow();
                    row["DrinkID"] = item.DrinkID;
                    row["DrinkName"] = item.DrinkName;
                    row["Price"] = item.Price;
                    row["Stock"] = item.Stock;
                    row["Category"] = item.Category;
                    dataset.Tables["Drink"].Rows.Add(row);
                }
            }
        }

        private void AddNewDrink()
        {
            // 텍스트 박스에서 값 읽기
            string drinkName = DrinkName.Text;
            string price = Price.Text;
            string stock = Stock.Text;
            string category = Category.Text;

            // 새로운 DrinkID 생성 (마지막 DrinkID + 1)
            int newDrinkID = 1;
            if (dataset.Tables["Drink"].Rows.Count > 0)
            {
                var lastRow = dataset.Tables["Drink"].Rows[dataset.Tables["Drink"].Rows.Count - 1];
                newDrinkID = Convert.ToInt32(lastRow["DrinkID"]) + 1;
            }

            // 새로운 행 추가
            DataRow newRow = dataset.Tables["Drink"].NewRow();
            newRow["DrinkID"] = newDrinkID;
            newRow["DrinkName"] = drinkName;
            newRow["Price"] = price;
            newRow["Stock"] = stock;
            newRow["Category"] = category;
            dataset.Tables["Drink"].Rows.Add(newRow);
        }

        private void DataSourceGridView()
        {
            dataGridView1.DataSource = dataset.Tables["Drink"];
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCSVData();
                MessageBox.Show("Data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SaveCSVData()
        {
            foreach (var file in csvList)
            {
                var lines = new List<string>();
                string[] columnNames = dataset.Tables["Drink"].Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                var header = string.Join(",", columnNames);
                lines.Add(header);

                var valueLines = dataset.Tables["Drink"].AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => val.ToString())));
                lines.AddRange(valueLines);

                File.WriteAllLines(file, lines, Encoding.Default);
            }
        }

        public class Drink
        {
            public string DrinkID { get; set; }
            public string DrinkName { get; set; }
            public string Price { get; set; }
            public string Stock { get; set; }
            public string Category { get; set; }
        }
    }
}
