using PacketLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class CompleteCallForm : Form
    {
        public CompleteCallForm()
        {
            InitializeComponent();
        }
        private NetworkStream m_networkstream;
        private TcpListener m_listener;

        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;
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

                switch ((int)packet.Type)
                {
                    case (int)PacketType.알림:
                        {
                            CompleteCall completeCall = (CompleteCall)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txt_server_state.AppendText(completeCall.orderID + "번 주문 고객님, 메뉴가 준비되었습니다."+ "\r\n");
                            }));
                                break;
                        }
                }
            }
        }

        private void CompleteCall_Load(object sender, EventArgs e)
        {
            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.Start();
        }

        private void CompleteCall_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            this.m_networkstream.Close();
            this.m_thread.Abort();
        }
    }
}
