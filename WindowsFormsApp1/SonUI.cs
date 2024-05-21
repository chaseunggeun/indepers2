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
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class SonUI : Form
    {
        public SonUI()
        {
            InitializeComponent();
        }
        public ShoppingCart shoppingCart;
        public Beverage beverage;
        public int orderNum;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        public void AddItem(string name,  double cost,categories category, string icon)
        {
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("icons/" + icon)
            };
            pnl.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                Option option = new Option(wdg);
                option.Owner = this;
                option.ShowDialog();
                shoppingCart.AddItem(beverage);
                if(wdg.Category == categories.Dessert)
                {
                    beverage.option[0] = -1; 
                }
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1 ;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString())) * wdg._cost; 
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.Cost });
                CalculateTotal();
            };
        }

        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                
                tot += int.Parse(item.Cells[2].Value.ToString().Replace(",", "").Replace("krw", ""));
            }
            lblTot.Text = tot.ToString("C2");
        }
        public void RemoveAllItems()
        {
            foreach(Widget widget in pnl.Controls)
            {
                pnl.Controls.Remove(widget);
            }
        }
        private void loadItem()
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
        private void SonUI_Shown(object sender, EventArgs e)
        {
            loadItem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in pnl.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var wdg = (Widget)item;
                    wdg.Visible = wdg.lblTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
                }
            }
        }

        private void SonUI_Load(object sender, EventArgs e)
        {
            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect("127.0.0.1", 7777);
            }
            catch
            {
                MessageBox.Show("접속 에러");
                return;
            }
            this.m_bConnect = true;
            this.m_networkstream = this.m_client.GetStream();

            shoppingCart = new ShoppingCart();
            orderNum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTot.Text = "\\0 krw";
            shoppingCart.items.Clear();
            grid.Rows.Clear();
        }
        
        //통신
        private NetworkStream m_networkstream;
        private TcpClient m_client;
        private byte[] sendBuffer = new byte[1024 * 4];
        private bool m_bConnect = false;

        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            shoppingCart.orderNum = this.orderNum;
            shoppingCart.Type = (int)PacketType.주문;

            Packet.Serialize(shoppingCart).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("주문이 완료되었습니다.\n");
            orderNum++;
            lblTot.Text = "\\0 krw";
            shoppingCart.items.Clear();
            grid.Rows.Clear();
            pnl.Controls.Clear();
            loadItem();
        }

        private void SonUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }
    }
}
