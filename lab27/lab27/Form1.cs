using System;
using System.IO;
using System.Windows.Forms;

namespace Lab27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDrives.Items.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                cmbDrives.Items.Add(drive.Name);
            }
        }

        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDirectories.Items.Clear();
            lstFiles.Items.Clear();
            txtInfo.Clear();

            try
            {
                string drivePath = cmbDrives.SelectedItem.ToString();

                foreach (string dir in Directory.GetDirectories(drivePath))
                {
                    lstDirectories.Items.Add(dir);
                }

                DriveInfo drive = new DriveInfo(drivePath);

                txtInfo.Text =
                    "Назва диска: " + drive.Name +
                    "\r\nТип: " + drive.DriveType +
                    "\r\nРозмір: " + drive.TotalSize +
                    "\r\nВільно: " + drive.TotalFreeSpace;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();

            try
            {
                string dirPath = lstDirectories.SelectedItem.ToString();

                foreach (string file in Directory.GetFiles(dirPath))
                {
                    lstFiles.Items.Add(file);
                }

                DirectoryInfo dir = new DirectoryInfo(dirPath);

                txtInfo.Text =
                    "Назва папки: " + dir.Name +
                    "\r\nПовний шлях: " + dir.FullName +
                    "\r\nСтворено: " + dir.CreationTime +
                    "\r\nЗмінено: " + dir.LastWriteTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filePath = lstFiles.SelectedItem.ToString();

                FileInfo file = new FileInfo(filePath);

                txtInfo.Text =
                    "Ім'я файлу: " + file.Name +
                    "\r\nРозширення: " + file.Extension +
                    "\r\nРозмір: " + file.Length + " байт" +
                    "\r\nСтворено: " + file.CreationTime;

                string ext = file.Extension.ToLower();

                if (ext == ".jpg" || ext == ".jpeg" ||
                    ext == ".png" || ext == ".bmp")
                {
                    pictureBox1.ImageLocation = filePath;
                }
                else
                {
                    pictureBox1.Image = null;
                }

                if (ext == ".txt")
                {
                    txtInfo.Text += "\r\n\r\nВміст файлу:\r\n";
                    txtInfo.Text += File.ReadAllText(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (lstDirectories.SelectedItem == null)
            {
                MessageBox.Show("Оберіть папку");
                return;
            }

            try
            {
                lstFiles.Items.Clear();

                string path = lstDirectories.SelectedItem.ToString();
                string filter = txtFilter.Text;

                foreach (string file in Directory.GetFiles(path, filter))
                {
                    lstFiles.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            txtInfo.Clear();

            lstDirectories.Items.Clear();
            lstFiles.Items.Clear();

            pictureBox1.Image = null;

            cmbDrives.SelectedIndex = -1;
        }
    }
}