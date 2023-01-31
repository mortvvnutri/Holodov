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
    public partial class Пробелы : Form
    {
        int Prob = 0;
        public Пробелы()
        {
            InitializeComponent();
        }


        private void Пробелы_Load(object sender, EventArgs e)
        {
            string[] countries = { "счсчссч счсчсчс счсчс чсчсч счс", "лдлдлд лдлдлдлд лддлдл длдлд", "аапап апаапап апапап апап", "ололо ололол ллолол оооллоло" };
            listBox1.Items.AddRange(countries);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int b = 0;
            foreach (string item in listBox1.Items)
            {
                foreach (char ch in item)
                    if (ch == ' ') b++;
            }
            Data.Value = index.ToString();
            Data.Value2 = b.ToString();

            Пробелывывод frm = new Пробелывывод();
            frm.ShowDialog();
        }

    }
}
