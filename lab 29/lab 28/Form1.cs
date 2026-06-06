using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UdpChat
{
    public partial class Form1 : Form
    {
        bool alive = false;
        UdpClient client;

        int LOCALPORT = 8001;
        int REMOTEPORT = 8001;
        int TTL = 20;

        string HOST = "235.5.5.1";

        IPAddress groupAddress;
        string userName;

        public Form1()
        {
            InitializeComponent();

            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;

            chatTextBox.ReadOnly = true;

            groupAddress = IPAddress.Parse(HOST);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введіть ім'я користувача!");
                return;
            }

            userNameTextBox.ReadOnly = true;

            try
            {
                client = new UdpClient(LOCALPORT);

                client.JoinMulticastGroup(groupAddress, TTL);

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " увійшов в чат";

                byte[] data = Encoding.Unicode.GetBytes(message);

                client.Send(data,
                            data.Length,
                            HOST,
                            REMOTEPORT);

                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            alive = true;

            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;

                    byte[] data = client.Receive(ref remoteIp);

                    string message =
                        Encoding.Unicode.GetString(data);

                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time =
                            DateTime.Now.ToShortTimeString();

                        chatTextBox.Text =
                            time + " " +
                            message + Environment.NewLine +
                            chatTextBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;

                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(messageTextBox.Text))
                    return;

                string message =
                    $"{userName}: {messageTextBox.Text}";

                byte[] data =
                    Encoding.Unicode.GetBytes(message);

                client.Send(data,
                            data.Length,
                            HOST,
                            REMOTEPORT);

                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ExitChat()
        {
            try
            {
                string message =
                    userName + " покинув чат";

                byte[] data =
                    Encoding.Unicode.GetBytes(message);

                client.Send(data,
                            data.Length,
                            HOST,
                            REMOTEPORT);

                client.DropMulticastGroup(groupAddress);

                alive = false;

                client.Close();

                loginButton.Enabled = true;
                logoutButton.Enabled = false;
                sendButton.Enabled = false;

                userNameTextBox.ReadOnly = false;
            }
            catch
            {
            }
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                chatTextBox.Font = fd.Font;
            }
        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Текстові файли (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(
                    sfd.FileName,
                    chatTextBox.Text,
                    Encoding.UTF8);

                MessageBox.Show("Лог успішно збережено!");
            }
        }
    }
}