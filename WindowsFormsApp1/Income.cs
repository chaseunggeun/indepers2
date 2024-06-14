using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Order.csv");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Order.csv file does not exist.");
                return;
            }

            DataTable dataTable = new DataTable();

            string[] csvLines = File.ReadAllLines(filePath);
            if (csvLines.Length > 0)
            {
                string[] headers = csvLines[0].Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }
                for (int i = 1; i < csvLines.Length; i++)
                {
                    string[] rowData = csvLines[i].Split(',');
                    dataTable.Rows.Add(rowData);
                }
            }

            dgvIncome.DataSource = dataTable;

            // Calculate total price
            int TotalPrice = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                int price;
                if (int.TryParse(row["Price"].ToString(), out price))
                {
                    TotalPrice += price;
                }
            }

            totalPrice.Text = "총계: " + TotalPrice.ToString() + "원";
        }
    }
}
