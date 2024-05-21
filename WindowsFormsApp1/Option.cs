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
using PacketLibrary;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class Option : Form
    {
        public Widget widget1;
        int[] optionarr;
        public Option(Widget widget)
        {
            InitializeComponent();
            this.widget1 = new Widget()
            {
                Title = widget.Title,
                Cost = widget.Cost,
                Category = widget.Category,
                Icon = widget.Icon
            };
        }

        private void Option_Load(object sender, EventArgs e)
        {
            string beverageName = widget1.Title;
            lbl_selectedBeverage.Text = beverageName;
            optionarr = new int[4];
            disableOption();
        }

        private void disableOption()
        {
            if(widget1.Category == categories.Dessert)
            {
                Radio_ice.Enabled = false;
                Radio_hot.Enabled = false;
                Radio_caffein.Enabled = false;
                Radio_decaffein.Enabled = false;
                Radio_iceLess.Enabled = false;
                Radio_iceNormal.Enabled = false;
                Radio_IceMore.Enabled = false;
            }
        }
        public void setOption()
        {
            if (Radio_ice.Checked) optionarr[0] = 0;
            else optionarr[0] = 1;

            if (Radio_caffein.Checked)
            {
                optionarr[1] = 2;
            }
            else
            {
                optionarr[1] = 3;
            }

            if (Radio_iceLess.Checked)
            {
                optionarr[2] = 4;
            }
            else if (Radio_iceNormal.Checked)
            {
                optionarr[2] = 5;
            }
            else
            {
                optionarr[2] = 6;
            }
            if(Radio_inStore.Checked)
            {
                optionarr[3] = 7;
            }
            else
            {
                optionarr[3] = 8;
            }
        }

        private void btn_addShoppingCart_Click(object sender, EventArgs e)
        {
            setOption();
            this.Close();
        }

        private void Option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Beverage beverage = new Beverage((int)widget1.Cost, widget1.Title, widget1.Category.ToString(), optionarr, false);
            ((SonUI)(this.Owner)).beverage = beverage;
        }
    }
}
