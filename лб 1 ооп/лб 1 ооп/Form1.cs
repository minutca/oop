using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
namespace лб_1_ооп
{
    using System.Linq;
    public partial class FrmMain : Form
    {
        private object listResault;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double result = (Math.Cos(x) / (Math.PI - 2 * x) + 16 * x * Math.Cos(x * y) - 2);
            lblResult.Text = result.ToString();
            listResult.Items.Add(result.ToString());
        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtX.Text != "")
            {
                return;
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (TxtX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnRun.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtY.Text != "")
            {
                return;
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtY.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnRun.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TxtX.Clear();
            txtY.Clear();
            listResult.Items.Clear();
            lblResult.Text = string.Empty;
        }

        private void ф_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double g = Convert.ToDouble(tG.Text);

                double h = ((a - b) / 2) * Math.Tan(g);
                double S = ((a + b) / 2) * h;

                listResult2.Items.Add("h = " + h.ToString("F3"));
                listResult2.Items.Add("S = " + S.ToString("F3"));
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            {
                txtA.Clear();
                txtB.Clear();
                tG.Clear();
                listResult2.Items.Clear();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRun3_Click(object sender, EventArgs e)
        {

            try
            {
                double x = Convert.ToDouble(txtX3.Text);
                double y = Convert.ToDouble(txtY3.Text);

                if (x > 0 && y > 0)
                    listResult3.Items.Add("Точка належить 1 чверті");
                else
                    listResult3.Items.Add("Точка НЕ належить 1 чверті");
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            {
                TxtX.Clear();
                txtY.Clear();
                listResult.Items.Clear();
                lblResult.Text = string.Empty;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            txtX3.Clear();
            txtY3.Clear();
            listResult3.Items.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRun4_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    double A = Convert.ToDouble(txtA4.Text);
                    double B = Convert.ToDouble(txtB4.Text);

                    double x = Convert.ToDouble(txtX4.Text);
                    double y = Convert.ToDouble(txtY4.Text);
                    double z = Convert.ToDouble(txtZ4.Text);

                    bool pass =
                        (x <= A && y <= B) || (x <= B && y <= A) ||
                        (x <= A && z <= B) || (x <= B && z <= A) ||
                        (y <= A && z <= B) || (y <= B && z <= A);

                    if (pass)
                        listResult4.Items.Add("Цегла проходить");
                    else
                        listResult4.Items.Add("Цегла НЕ проходить");
                }
                catch
                {
                    MessageBox.Show("Помилка введення!");
                }
            }
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {

            {
                txtA4.Clear();
                txtB4.Clear();
                txtX4.Clear();
                txtY4.Clear();
                txtZ4.Clear();

                listResult4.Items.Clear();
            }
        }

        private void label18_Click(object sender, EventArgs e)


        {
            try
            {
                int n = Convert.ToInt32(txtN5.Text);

                int maxNumber = 2;
                int maxSum = 0;

                for (int i = 2; i <= n; i++)
                {
                    int sum = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxNumber = i;
                    }
                }

                listResult5.Text =
                    "Число: " + maxNumber + Environment.NewLine +
                    "Сума дільників: " + maxSum;
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntClear5_Click(object sender, EventArgs e)
        {


            {

            }
        }



        private void btnRun5_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtN5.Text);

                int maxNumber = 2;
                int maxSum = 0;

                for (int i = 2; i <= n; i++)
                {
                    int sum = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxNumber = i;
                    }
                }

                listResult55.Items.Add("Число: " + maxNumber);
                listResult55.Items.Add("Сума дільників: " + maxSum);
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }


        private void btnClear5_Click(object sender, EventArgs e)
        {

            {
                txtN5.Clear();
                listResult55.Items.Clear();
            }
        }


        private void btnRun5_Click_1(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtN5.Text);

                int maxNumber = 2;
                int maxSum = 0;
                for (int i = 2; i <= n; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxNumber = i;
                    }
                }
                listResult55.Items.Clear();
                listResult55.Items.Add("Число: " + maxNumber);
                listResult55.Items.Add("Сума дільників: " + maxSum);
            }
            catch
            {
                MessageBox.Show("Помилка введення! Будь ласка, введіть ціле число.");
            }
        }

        private void txtArray6_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnRun6_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = txtArray6.Text
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int k = 0;

                for (int i = 0; i < arr.Length; i += 2)
                {
                    arr[k] = arr[i];
                    k++;
                }

                Array.Resize(ref arr, k);

                listResult6.Items.Clear();
                listResult6.Items.Add("Новий масив:");
                listResult6.Items.Add(string.Join(" ", arr));
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void btnRun6_Click_1(object sender, EventArgs e)
        {

            {
                try
                {
                    int[] arr = txtArray6.Text
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

                    int k = 0;

                    for (int i = 0; i < arr.Length; i += 2)
                    {
                        arr[k] = arr[i];
                        k++;
                    }

                    Array.Resize(ref arr, k);

                    listResult6.Items.Clear();
                    listResult6.Items.Add("Новий масив:");
                    listResult6.Items.Add(string.Join(" ", arr));
                }
                catch
                {
                    MessageBox.Show("Помилка введення!");
                }
            }
        }

        private void btnClear6_Click(object sender, EventArgs e)
        {

            {
                txtArray6.Clear();
                listResult6.Items.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            try
            {
                string s = txtString7.Text;

                int start = s.IndexOf('(');
                int end = s.IndexOf(')');

                if (start == -1 || end == -1 || start > end)
                {
                    MessageBox.Show("Дужки введені неправильно!");
                    return;
                }

                string result = s.Substring(start + 1, end - start - 1);

                listResult7.Items.Clear();
                listResult7.Items.Add("Символи між дужками:");
                listResult7.Items.Add(result);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void btnClear7_Click(object sender, EventArgs e)
        {
 
        {
            txtString7.Clear();
            listResult7.Items.Clear();
        }
    }
    }
}


    





    internal class Pi
    {
    }

  
