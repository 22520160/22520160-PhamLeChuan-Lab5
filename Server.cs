using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Lab05
{
    public partial class Server : Form
    {
        List<string> servers = new List<string>();
        public Server()
        {
            InitializeComponent();
        }
        public void Receive(Socket clientSocket)
        {
            string a = txttaikhoan.Text;
            string b = txtmatkhau.Text;
            while (clientSocket.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = clientSocket.Receive(buffer);
                    string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string[] tach = text.Split(';');
                    if (servers.Contains(text))
                    {
                        string message = "Fail;";
                        byte[] buffer_ = Encoding.UTF8.GetBytes(message);
                        clientSocket.Send(buffer_);
                    }
                    else
                    {
                        servers.Add(text);
                        string message = "Success;" + tach[2] + ";" + tach[0] + ";" + tach[1] + ";" + a + ";" + b;
                        byte[] buffer_ = Encoding.UTF8.GetBytes(message);
                        clientSocket.Send(buffer_);
                    }
                }
                catch (SocketException sockEx)
                {
                    MessageBox.Show("Socket Exception: " + sockEx.Message);
                    clientSocket.Close(); 
                    break; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error receiving message: " + ex.Message);
                    clientSocket.Close(); 
                    break; 
                }
            }
        }
        public void StartListening()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Bind(ip);
            listener.Listen(5);
            while (true)
            {
                Socket clientSocket = listener.Accept();
                Thread thread = new Thread(() => Receive(clientSocket));
                thread.Start();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartListening);
            thread.Start();
        }
    }
}
