using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Components;

namespace WindowsFormsApp1
{
    public partial class SonUI : Form
    {
        public SonUI()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        public void AddItem(string name,  double cost,categories category, string icon)
        {
            pnl.Controls.Add(new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("icons/" + icon)
            }) ;
        }

        private void SonUI_Shown(object sender, EventArgs e)
        {
            //coffee
            AddItem("아메리카노", 3000, categories.Coffee, "americano.png");
            AddItem("카페라떼", 3500, categories.Coffee, "cafelatte.png");
            //non-coffee
            AddItem("아이스티", 2500, categories.nonCoffee, "icetea.png");
            AddItem("말차 라떼", 3500, categories.nonCoffee, "matchalatte.png");
            AddItem("밀크티", 3500, categories.nonCoffee, "milktea.png");
            AddItem("초콜렛 라떼", 3500, categories.nonCoffee, "chocolatelatte.png");
            //dessert
            AddItem("베이글", 3000, categories.Dessert, "bagel.png");
            AddItem("초콜렛칩 쿠키", 2000, categories.Dessert, "cookie.png");
            AddItem("딸기 케이크", 6000, categories.Dessert, "strawberrycake.png");
            AddItem("와플", 3500, categories.Dessert, "waffle.png");
            AddItem("마카롱", 4000, categories.Dessert, "macaron.png");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in pnl.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }
    }
}
