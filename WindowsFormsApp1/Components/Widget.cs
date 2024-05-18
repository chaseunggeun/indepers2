using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{

    public enum categories { Coffee, nonCoffee, Dessert}
    public partial class Widget : UserControl
    {

        private categories _category;
        public double _cost;

        public event EventHandler OnSelect = null;
        public Widget()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this,e);
        }


        public categories Category { get => _category; set => _category = value; }

        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2"); } }

        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }


    }
}
