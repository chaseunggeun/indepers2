using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DataSetTest : Form
    {
        DataSet1 dataset;
        public DataSetTest()
        {
            InitializeComponent();
            dataset = new DataSet1();

            dataset.Tables["Drink"].Rows.Add(new object[] { 1, "아메리카노", 5500, 100, "Coffee" });
            dataset.Tables["Drink"].Rows.Add(new object[] { 2, "카페라떼", 6000, 100, "Coffee" });
            dataset.Tables["Drink"].Rows.Add(new object[] { 3, "그린티라떼", 6000, 100, "NonCoffee" });
            dataGridView1.DataSource = dataset.Tables["Drink"];
        }
    }
}
