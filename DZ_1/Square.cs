using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Square_Load(object sender, EventArgs e)
        {
            // Начальное значение X 
            textBox1.Text = "3";
            // Начальное значение Y 
            textBox2.Text = "4";
            // Начальное значение Z 
            textBox3.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            // Считывание значения X 
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double x1, x2;

            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                textBox4.Text += Environment.NewLine + "Квадратное уравнение не имеет корней";
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                //вывод корней уравнения
                textBox4.Text += Environment.NewLine + $"x1 = {x1}; x2 = {x2}";
            }
        }
    }
}
