using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using PacketLibrary;

namespace WindowsFormsApp1
{
    public partial class SaUI : Form
    {
        private int orderID = 1; // Initialize OrderID

        public SaUI()
        {
            InitializeComponent();
        }

        public event EventHandler<OrderCompletedEventArgs> OrderCompleted;

        private void SetUpListView1()
        {
            lvwOrder.Columns.Add("Num", "주문번호");
            lvwOrder.Columns.Add("Order", "주문목록");
            lvwOrder.Columns.Add("Time", "주문시간");
            lvwOrder.Columns.Add("Cost", "금액");
            lvwOrder.Columns.Add("Going", "진행도");
            lvwOrder.Columns.Add("Option", "옵션");
        }

        private void SetUpListView2()
        {
            lvwOrderCom.Columns.Add("Num", "주문번호");
            lvwOrderCom.Columns.Add("Order", "주문목록");
            lvwOrderCom.Columns.Add("Time", "주문시간");
            lvwOrderCom.Columns.Add("Cost", "금액");
            lvwOrderCom.Columns.Add("Going", "진행도");
            lvwOrderCom.Columns.Add("Option", "옵션");
        }

        private void SaUI_Load(object sender, EventArgs e)
        {
            SetUpListView1();
            SetUpListView2();
            lvwOrder.SelectedIndexChanged += LvwOrder_SelectedIndexChanged;

            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.Start();
        }

        private void LvwOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwOrder.SelectedItems.Count == 0)
                return;

            btnComplete.Enabled = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lvwOrder.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = lvwOrder.SelectedItems[0];
            selectedItem.SubItems[4].Text = "완료";
            lvwOrderCom.Items.Add((ListViewItem)selectedItem.Clone());

            OnOrderCompleted(selectedItem.SubItems[0].Text, selectedItem.SubItems[4].Text);

            lvwOrder.Items.Remove(selectedItem);

            btnComplete.Enabled = false;
        }

        protected virtual void OnOrderCompleted(string orderNumber, string orderCost)
        {
            OrderCompleted?.Invoke(this, new OrderCompletedEventArgs(orderNumber, orderCost));
        }

        public class OrderCompletedEventArgs : EventArgs
        {
            public string OrderNumber { get; }
            public string OrderCost { get; }

            public OrderCompletedEventArgs(string orderNumber, string orderCost)
            {
                OrderNumber = orderNumber;
                OrderCost = orderCost;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lvwOrder.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = lvwOrder.SelectedItems[0];

            lvwOrder.Items.Remove(selectedItem);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form2 inventoryForm = new Form2();
            inventoryForm.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Income incomeForm = new Income();
            incomeForm.ShowDialog();
        }

        private void CopyListViewItems(ListView source, ListView destination)
        {
            destination.Items.Clear();
            destination.Columns.Clear();

            foreach (ColumnHeader column in source.Columns)
            {
                destination.Columns.Add((ColumnHeader)column.Clone());
            }

            foreach (ListViewItem item in source.Items)
            {
                ListViewItem newItem = new ListViewItem(item.Text);
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem != item.SubItems[0])
                    {
                        newItem.SubItems.Add(subItem.Text);
                    }
                }
                destination.Items.Add(newItem);
            }
        }

        // 통신
        private NetworkStream m_networkstream;
        private TcpListener m_listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;

        public ShoppingCart m_shoppingCartClass;

        private void SaUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            this.m_networkstream.Close();
            this.m_thread.Abort();
        }

        public void RUN()
        {
            this.m_listener = new TcpListener(IPAddress.Any, 7777);
            this.m_listener.Start();

            TcpClient client = this.m_listener.AcceptTcpClient();

            if (client.Connected)
            {
                this.m_bClientOn = true;
                m_networkstream = client.GetStream();
            }

            int nRead = 0;

            while (this.m_bClientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bClientOn = false;
                    this.m_networkstream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.주문:
                        {
                            ShoppingCart receivedCart = (ShoppingCart)Packet.Desserialize(this.readBuffer);
                            foreach (var item in receivedCart.items)
                            {
                                string option = "";
                                foreach (var a in item.option)
                                {
                                    if (a == -1)
                                    {
                                        break;
                                    }
                                    if (a == 0) option += "ICE, ";
                                    if (a == 1) option += "HOT, ";
                                    if (a == 2) option += "카페인, ";
                                    if (a == 3) option += "디카페인, ";
                                    if (a == 4) option += "얼음적게, ";
                                    if (a == 5) option += "얼음보통, ";
                                    if (a == 6) option += "얼음많이, ";
                                    if (a == 7) option += "매장";
                                    if (a == 8) option += "포장";
                                }
                                string[] row = new string[] { receivedCart.orderNum.ToString(), item.getName(),
                                DateTime.Now.ToString("tt h시 mm분"), item.getPrice().ToString(), "진행 중", option };
                                AddOrderToListView(row);
                                SaveOrderToCSV(item.getName(), DateTime.Now.ToString("tt h시 mm분"), item.getPrice().ToString());
                            }
                            break;
                        }
                }
            }
        }

        private void AddOrderToListView(string[] row)
        {
            if (lvwOrder.InvokeRequired)
            {
                lvwOrder.Invoke(new Action<string[]>(AddOrderToListView), new object[] { row });
            }
            else
            {
                lvwOrder.Items.Add(new ListViewItem(row));
            }
        }

        private void SaveOrderToCSV(string orderedDrink, string date, string price)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Order.csv");

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("OrderID,OrderedDrink,Date,Price");
                }
            }

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{orderID},{orderedDrink},{date},{price}");
                orderID++;
            }
        }
    }
}
