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
        DataSet DataSet;
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

        private void btn_DBtest_Click(object sender, EventArgs e)
        {
            DataSetTest formTest = new DataSetTest();
            formTest.Owner = this;
            formTest.Show();
            this.Visible = false;
        }

        private void btn_SonUITest_Click(object sender, EventArgs e)
        {
            SonUI formUI = new SonUI();
            formUI.Owner = this;
            formUI.Show();
            this.Visible = false;
        }

        private void btnSaUi_Click(object sender, EventArgs e)
        {
            SaUI SaUI = new SaUI();
            SaUI.Owner = this;
            SaUI.Show();
            this.Visible = false;
        }
    }
}
