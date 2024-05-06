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

        public Initiailize m_initializeClass;
        public Login m_loginClass;

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

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            Initiailize Init = new Initiailize();
            Init.Type = (int)PacketType.초기화;
            Init.Data = Int32.Parse(this.txt_init.Text);

            Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            Login login = new Login();
            login.Type = (int)PacketType.로그인;
            login.m_strID = this.txt_login.Text;

            Packet.Serialize(login).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void FormSon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }

        private void btn_damgi_Click(object sender, EventArgs e)
        {
            Beverage beverage = new Beverage(txt_bvgname.Text, int.Parse(txt_bvgprice.Text));
            shoppingCart.AddItem(beverage);
            RefreshShoppingCart();
        }
        private void InitializeShoppingCartListView()
        {
            lvw_shoppingcart.Clear();
            lvw_shoppingcart.Columns.Add("name", "Name");
            lvw_shoppingcart.Columns.Add("price", "Price");
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
                ListViewItem bvgItem = new ListViewItem(item.Name);
                bvgItem.SubItems.Add(item.Price.ToString());
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
