using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketLibrary;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class FormSon : Form
    {
        public FormSon()
        {
            InitializeComponent();
        }
        private NetworkStream m_networkstream;
        private TcpClient m_client;
        private byte[] sendBuffer = new byte[1024 * 4];
        private bool m_bConnect = false;
        public ShoppingCart shoppingCart;


        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect(this.txt_ip.Text, 7777);
            }
            catch
            {
                MessageBox.Show("접속 에러");
                return;
            }
            this.m_bConnect = true;
            this.m_networkstream = this.m_client.GetStream();
        }

       

        private void FormSon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }

        private void btn_damgi_Click(object sender, EventArgs e)
        {
            
            int[] option = { };
            Beverage beverage = new Beverage(int.Parse(txt_bvgprice.Text), txt_bvgname.Text, txt_bvgCategory.Text, option, false);
            shoppingCart.AddItem(beverage);
            RefreshShoppingCart();
        }
        private void InitializeShoppingCartListView()
        {
            lvw_shoppingcart.Clear();
            lvw_shoppingcart.Columns.Add("name", "Name");
            lvw_shoppingcart.Columns.Add("price", "Price");
            lvw_shoppingcart.Columns.Add("category", "Category");
            lvw_shoppingcart.Columns.Add("option", "Option");
        }

        private void FormSon_Load(object sender, EventArgs e)
        {
            shoppingCart = new ShoppingCart();
            InitializeShoppingCartListView();
        }

        private void RefreshShoppingCart()
        {
            lvw_shoppingcart.Items.Clear();
            foreach (var item in shoppingCart.items)
            {
                ListViewItem bvgItem = new ListViewItem(item.getName());
                bvgItem.SubItems.Add(item.getPrice().ToString());
                bvgItem.SubItems.Add(item.getCategory().ToString());
                lvw_shoppingcart.Items.Add(bvgItem);
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            shoppingCart.Type = (int)PacketType.주문;

            Packet.Serialize(shoppingCart).CopyTo(this.sendBuffer, 0);
            this.Send();
        }
    }
}
