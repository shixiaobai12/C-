using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算题器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        string op;
            int result;
        Random rnd = new Random() ;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            double d = double.Parse(str);
            string D = "" + a + op + b + "=" + d + "";
            if (d == result)
                D += "   正确";
            else
                D += "   错误";
            listBox1.Items.Add(D);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            int c = rnd.Next(4);
            switch (c)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;
                case 2: op = "*"; result = a * b; break;
                case 3: op = "/"; result = a / b; break;

            }
            label1.Text = a.ToString();
            label2.Text = op.ToString();
            label3.Text = b.ToString();
            textBox1.Text = "";
        }
    }
}
