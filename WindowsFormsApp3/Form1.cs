using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string[] data = new string[3] { "Sin", "Cos", "Tg" };

        public Form1()
        {
            InitializeComponent();           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            string func = listBox1.Text;
            double x, F;
            bool b = double.TryParse(textBox1.Text, out x);
            if (!b) // b == false
            {
                MessageBox.Show("Неверный формат данных");
                return;
            }
            if (func == "Sin")
            {
                F = Math.Sin(x);
            }
            else if (func == "Cos")
            {
                F = Math.Cos(x);
            }
            else
            {
                F = Math.Tan(x);
            }
            textBox2.Text = F.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = data;
        }
    }
}
