using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lb24
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;

        bool work = true;

        public Form1()
        {
            InitializeComponent();

            thread1 = new Thread(Method1);
            thread2 = new Thread(Method2);
            thread3 = new Thread(Method3);
        }

        private void Method1()
        {
            while (work)
            {
                try
                {
                    string text = txtInput.Text;

                    byte[] data = Encoding.UTF8.GetBytes(text);

                    using (Aes aes = Aes.Create())
                    {
                        ICryptoTransform encryptor = aes.CreateEncryptor();

                        byte[] encrypted =
                            encryptor.TransformFinalBlock(data, 0, data.Length);

                        Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.AppendText(
                                "CA-1.1: " +
                                Convert.ToBase64String(encrypted) +
                                Environment.NewLine);
                        });
                    }
                }
                catch { }

                Thread.Sleep(2000);
            }
        }

        private void Method2()
        {
            while (work)
            {
                try
                {
                    string text = txtInput.Text;

                    SHA256 sha = SHA256.Create();

                    byte[] hash =
                        sha.ComputeHash(Encoding.UTF8.GetBytes(text));

                    Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(
                            "Хеш: " +
                            BitConverter.ToString(hash) +
                            Environment.NewLine);
                    });
                }
                catch { }

                Thread.Sleep(2000);
            }
        }

        private void Method3()
        {
            Random rnd = new Random();

            while (work)
            {
                try
                {
                    int number = rnd.Next(1, 100000);

                    Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(
                            "Nanoteq: " +
                            number +
                            Environment.NewLine);
                    });
                }
                catch { }

                Thread.Sleep(1000);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            work = true;

            thread1 = new Thread(Method1);
            thread2 = new Thread(Method2);
            thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            work = false;
        }
            private void btnStop_Click(object sender, EventArgs e)
        {
            work = false;

            if (thread1 != null && thread1.IsAlive)
                thread1.Abort();

            if (thread2 != null && thread2.IsAlive)
                thread2.Abort();

            if (thread3 != null && thread3.IsAlive)
                thread3.Abort();
        }
    }
    }
