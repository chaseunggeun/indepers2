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
    public partial class SaUI : Form
    {
        public SaUI()
        {
            InitializeComponent();
        }

        public event EventHandler<OrderCompletedEventArgs> OrderCompleted;

        private void SetUpListView1()
        {
            lvwOrder.Columns.Add("Num", "주문번호");
            lvwOrder.Columns.Add("Type", "주문유형");
            lvwOrder.Columns.Add("Order", "주문목록");
            lvwOrder.Columns.Add("Time", "주문시간");
            lvwOrder.Columns.Add("Cost", "금액");
            lvwOrder.Columns.Add("Going", "진행도");
        }

        private void SetUpListView2()
        {
            lvwOrderCom.Columns.Add("Num", "주문번호");
            lvwOrderCom.Columns.Add("Type", "주문유형");
            lvwOrderCom.Columns.Add("Order", "주문목록");
            lvwOrderCom.Columns.Add("Time", "주문시간");
            lvwOrderCom.Columns.Add("Cost", "금액");
            lvwOrderCom.Columns.Add("Going", "진행도");

        }

        private void SaUI_Load(object sender, EventArgs e)
        {
            SetUpListView1();
            SetUpListView2();
            lvwOrder.SelectedIndexChanged += LvwOrder_SelectedIndexChanged;
            lvwOrder.Items.Add(new ListViewItem(new[] { "1", "매장", "아메리카노", DateTime.Now.ToString(), "15000", "진행 중" }));
            lvwOrder.Items.Add(new ListViewItem(new[] { "2", "포장", "카페라떼", DateTime.Now.ToString(), "5000", "진행 중" }));
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
            selectedItem.SubItems[5].Text = "완료";
            lvwOrderCom.Items.Add((ListViewItem)selectedItem.Clone());

            OnOrderCompleted(selectedItem.SubItems[0].Text, selectedItem.SubItems[5].Text);

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
            Inventory inventoryForm = new Inventory();
            inventoryForm.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Income incomeForm = new Income();
            incomeForm.AddItemsToListView(lvwOrderCom);
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
    }
}
