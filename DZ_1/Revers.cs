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
    public partial class Revers : Form
    {
        string text;
        public Revers()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] s = text.ToCharArray();
            Array.Reverse(s);
            textBox2.Text += Environment.NewLine;
            for (int i = 0; i < s.Length; i++)
            {
                textBox2.Text += s[i];
            }
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
