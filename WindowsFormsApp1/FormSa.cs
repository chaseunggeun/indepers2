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
using PacketLibrary;

namespace WindowsFormsApp1
{
    public partial class FormSa : Form
    {
        public FormSa()
        {
            InitializeComponent();
        }
        private NetworkStream m_networkstream;
        private TcpListener m_listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;

        public Initiailize m_initializeClass;
        public Login m_loginClass;
        public ShoppingCart m_shoppingCartClass;

        public void RUN()
        {
            this.m_listener = new TcpListener(7777);
            this.m_listener.Start();

            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txt_server_state.AppendText("클라이언트 접속 대기중\r\n");
                }));
            }

            TcpClient client = this.m_listener.AcceptTcpClient();

            if (client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txt_server_state.AppendText("클라이언트 접속\r\n");
                }));
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

                switch((int)packet.Type) {
                    case (int)PacketType.초기화:
                        {
                            this.m_initializeClass = (Initiailize)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txt_server_state.AppendText("패킷 전송 성공. " + "Initialize Class Data is " + this.m_initializeClass.Data + "\r\n");
                            }));
                            break;
                        }
                    case (int)PacketType.로그인:
                        {
                            this.m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txt_server_state.AppendText("패킷 전송 성공. " + "Login Class Data is " + this.m_loginClass.m_strID + "\r\n");
                            }));
                            break;
                        }
                    case (int)PacketType.주문:
                        {
                            ShoppingCart receivedCart = (ShoppingCart)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txt_server_state.AppendText("패킷 전송 성공. " + "Received Shopping Cart Data is " + receivedCart + "\r\n");
                                foreach (var item in receivedCart.items)
                                {
                                    this.txt_server_state.AppendText("이름: " + item.Name + ", " + "가격: " + item.Price.ToString() + "\r\n");
                                }
                                
                            }));
                            break;
                        }
                }
            }
        }

        private void FormSa_Load(object sender, EventArgs e)
        {
            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.Start();
        }

        private void FormSa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            this.m_networkstream.Close();
            this.m_thread.Abort();
        }
    }
}
