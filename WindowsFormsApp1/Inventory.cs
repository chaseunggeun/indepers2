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
    public partial class Inventory : Form
    {
        InventoryDummy.ALLDummy iAll = new InventoryDummy.ALLDummy();
        InventoryDummy.ivtCoffee iCoffee = new InventoryDummy.ivtCoffee();
        InventoryDummy.ivtNonCoffee iNoncof = new InventoryDummy.ivtNonCoffee();
        InventoryDummy.ivtDessert iDessert = new InventoryDummy.ivtDessert();

        public Inventory()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 580);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(iAll);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(iCoffee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(iNoncof);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(iDessert);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(iAll);
        }
    }
}
