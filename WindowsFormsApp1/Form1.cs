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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSon_Click(object sender, EventArgs e)
        {
            FormSon formSon = new FormSon();
            formSon.Owner = this;
            formSon.Show();
            this.Visible = false;
        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            FormSa formSa = new FormSa();
            formSa.Owner = this;
            formSa.Show();
            this.Visible = false;
        }

    }
}
