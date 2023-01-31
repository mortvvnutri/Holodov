using LB_1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Image = (System.Drawing.Bitmap)Resources.Screenshot_3;
            button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double v6 = Convert.ToDouble(textBox1.Text);
                double f = Convert.ToDouble(textBox2.Text);
                double h11 = Convert.ToDouble(textBox4.Text);
                double h3 = Convert.ToDouble(textBox6.Text);
                double d12 = Convert.ToDouble(textBox5.Text);
                double E = Math.Round(Math.Sin(h11 + (d12 / Math.Log(h11))) - v6 + Math.Abs(Math.Sin(h3)) + Math.Pow(Math.Abs(Math.Sin(f)), 1 / 2), 3);
                textBox3.Text = "E = " + (E).ToString();
            }
            catch 
            {
                MessageBox.Show ("Ведите данные по-человечески!");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox1.Text = e.X.ToString();

            textBox2.Text = e.Y.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

    }
}
