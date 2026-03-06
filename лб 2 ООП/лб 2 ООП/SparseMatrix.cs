using System.Collections.Generic;
using System.Text;

namespace лб_2_ООП
{
    internal class SparseMatrix
    {
        private int rows;
        private int cols;

        private List<Element> elements = new List<Element>();

        public SparseMatrix(int r, int c)
        {
            rows = r;
            cols = c;
        }

        public void AddElement(int r, int c, int value)
        {
            if (value != 0)
            {
                elements.Add(new Element(r, c, value));
            }
        }

        public string ShowMatrix()
        {
            int[,] matrix = new int[rows, cols];

            foreach (var el in elements)
            {
                matrix[el.Row, el.Col] = el.Value;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string ShowSubMatrix(int r1, int r2, int c1, int c2)
        {
            int[,] matrix = new int[rows, cols];

            foreach (var el in elements)
            {
                matrix[el.Row, el.Col] = el.Value;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = r1; i <= r2; i++)
            {
                for (int j = c1; j <= c2; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}