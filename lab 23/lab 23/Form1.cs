using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab_23
{
    public partial class Form1 : Form
    {
        double tStart = 0;
        double tEnd = 10 * Math.PI;
        double tStep = 0.01;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int w = pictBox1.Width;
            int h = pictBox1.Height;

            int centerX = w / 2;
            int centerY = h / 2;

            List<PointF> points = new List<PointF>();

            double scale = 10;

            for (double t = tStart;
                 t <= tEnd;
                 t += tStep)
            {
                double xVal = t * Math.Cos(t);
                double yVal = t * Math.Sin(t);

                float screenX =
                    (float)(centerX + xVal * scale);

                float screenY =
                    (float)(centerY - yVal * scale);

                points.Add(
                    new PointF(
                        screenX,
                        screenY));
            }

            if (points.Count > 1)
            {
                g.DrawLines(
                    new Pen(Color.Red, 2),
                    points.ToArray());
            }
        }

        private void btnDraw_Click(
            object sender,
            EventArgs e)
        {
            tStart =
                Convert.ToDouble(
                    txtStart.Text);

            tEnd =
                Convert.ToDouble(
                    txtEnd.Text);

            tStep =
                Convert.ToDouble(
                    txtStep.Text);

            pictBox1.Invalidate();
        }
    }
}