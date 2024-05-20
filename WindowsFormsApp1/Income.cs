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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        public ListView IncomeList => lvwIncomeList; // lvwIncomeList를 외부에서 접근할 수 있도록 함

        // 다른 클래스에서 lvwIncomeList에 항목을 추가하기 위한 메서드
        public void AddItemsToListView(ListView source)
        {
            foreach (ListViewItem item in source.Items)
            {
                ListViewItem newItem = new ListViewItem(item.SubItems[0].Text); // 주문번호 추가

                // 나머지 서브아이템 추가
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    newItem.SubItems.Add(item.SubItems[i].Text);
                }

                lvwIncomeList.Items.Add(newItem); // ListView에 ListViewItem 추가
            }
        }

    }
}
