using System;
using System.Windows.Forms;

namespace лб_2_ООП
{
    public partial class Form1 : Form
    {
        SparseMatrix matrix;

        public Form1()
        {
            InitializeComponent();

            matrix = new SparseMatrix(3, 3);

            matrix.AddElement(0, 2, 5);
            matrix.AddElement(2, 0, 3);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(textRows.Text);
            int cols = int.Parse(textCols.Text);

            matrix = new SparseMatrix(rows, cols);

            MessageBox.Show("Матрицю створено");
        }
        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            {
                int rows = int.Parse(textRows.Text);
                int cols = int.Parse(textCols.Text);
                matrix = new SparseMatrix(rows, cols);
                MessageBox.Show("Матрицю створено");
            }
        }
        private void buttonFill_Click(object sender, EventArgs e)

        {
            Random rnd = new Random();

            int rows = int.Parse(textRows.Text);
            int cols = int.Parse(textCols.Text);

            for (int i = 0; i < 10; i++)
            {
                int r = rnd.Next(rows);
                int c = rnd.Next(cols);
                int value = rnd.Next(1, 9);

                matrix.AddElement(r, c, value);
            }
            MessageBox.Show("Матрицю заповнено");
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            textMatrix.Text = matrix.ShowMatrix();
        }
        private void buttonSubMatrix_Click(object sender, EventArgs e)
       
        {
            textMatrix.Text = matrix.ShowSubMatrix(0, 1, 0, 1);
        }
    }
    }


