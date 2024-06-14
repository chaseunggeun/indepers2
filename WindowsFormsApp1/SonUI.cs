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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class SonUI : Form
    {
        private DataSet1 dataSet;

        public SonUI()
        {
            InitializeComponent();
            dataSet = new DataSet1();
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

        public void AddItem(string name, double cost, categories category, string icon, int stock)
        {
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("icons/" + icon)
            };

            if (stock == 0)
            {
                w.Enabled = false;
                w.Title += " (Sold Out)";
            }

            pnl.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                if (stock == 0)
                {
                    MessageBox.Show("This item is sold out.");
                    return;
                }

                var wdg = (Widget)ss;
                Option option = new Option(wdg);
                option.Owner = this;
                option.ShowDialog();
                shoppingCart.AddItem(beverage);
                if (wdg.Category == categories.Dessert)
                {
                    beverage.option[0] = -1;
                }
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
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

        public void ReadCsvAndPopulateTable(string filePath, DataTable drinkTable)
        {
            var lines = File.ReadAllLines(filePath);

            var columnNames = lines[0].Split(',');

            var dataLines = lines.Skip(1);
            foreach (var line in dataLines)
            {
                var values = line.Split(',');
                var row = drinkTable.NewRow();

                if (int.TryParse(values[0], out int drinkId))
                {
                    row["DrinkID"] = drinkId;
                }
                else
                {
                    row["DrinkID"] = 0;
                }

                row["DrinkName"] = values[1];

                if (double.TryParse(values[2], out double price))
                {
                    row["Price"] = price;
                }
                else
                {
                    row["Price"] = 0.0;
                }

                if (int.TryParse(values[3], out int stock))
                {
                    row["Stock"] = stock;
                }
                else
                {
                    row["Stock"] = 0;
                }

                row["Category"] = values[4];

                drinkTable.Rows.Add(row);
            }
        }
        private void loadItem()
        {
            try
            {
                string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Drink.csv");

                ReadCsvAndPopulateTable(csvFilePath, dataSet.Tables["Drink"]);

                foreach (DataRow row in dataSet.Tables["Drink"].Rows)
                {
                    string drinkName = row["DrinkName"].ToString();

                    if (!double.TryParse(row["Price"].ToString(), out double price))
                    {
                        price = 0.0;
                    }

                    if (!int.TryParse(row["Stock"].ToString(), out int stock))
                    {
                        stock = 0;
                    }

                    if (!Enum.TryParse(row["Category"].ToString(), out categories category))
                    {
                        category = categories.nonCoffee;
                    }

                    string icon = drinkName.ToLower().Replace(" ", "") + ".png";

                    AddItem(drinkName, price, category, icon, stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
        private void SonUI_Shown(object sender, EventArgs e)
        {
            loadItem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
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

        // 통신
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

            // Decrease stock values for ordered items
            foreach (var item in shoppingCart.items)
            {
                // Find the row in the DataTable
                foreach (DataRow row in dataSet.Tables["Drink"].Rows)
                {
                    if (row["DrinkName"].ToString() == item.getName())
                    {
                        if (int.TryParse(row["Stock"].ToString(), out int stock))
                        {
                            row["Stock"] = stock - 1;

                            // If stock reaches 0, mark as sold out
                            if (row["Stock"].ToString() == "0")
                            {
                                foreach (Control control in pnl.Controls)
                                {
                                    if (control is Widget w && w.Title == item.getName())
                                    {
                                        w.Enabled = false;
                                        w.Title += " (Sold Out)";
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
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
        }



        private void SonUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }
    }
}

