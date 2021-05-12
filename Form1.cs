using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruchy_Browna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["XY"].Points.Clear();
            double liczbaPi = 3.14159; //deklaracja stałej pi
            double x, y, s;
            double p = 2 * liczbaPi;
            long i, n;
            n = Convert.ToInt32(numericUpDown1.Value);
            x = 0;
            y = 0;
            Random rnd = new Random();
            chart1.Series["XY"].Points.AddXY(x, y);
            for (i = 0; i < n; i++)
            {
                x = x + 1 * Math.Cos(rnd.NextDouble() * p);
                y = y + 1 * Math.Cos(rnd.NextDouble() * p);
                chart1.Series["XY"].Points.AddXY(x, y);
            }
            s = Math.Sqrt(x * x + y * y);
            textBox2.Text = $"X: {Convert.ToString(x)}";
            textBox3.Text = $"Y: {Convert.ToString(y)}";
            textBox1.Text = $"Długość wektora przesunięcia cząsteczki po {Convert.ToString(n)} krokach: {s}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
