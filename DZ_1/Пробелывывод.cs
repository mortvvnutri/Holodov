using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Пробелывывод : Form
    {
        public Пробелывывод()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Пробелывывод_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.Value2;
            textBox2.Text = Data.Value;
        }
    }

}
