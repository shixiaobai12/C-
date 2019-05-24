using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 温度转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString("b");

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = vScrollBar2.Value.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            b = (9 / 5 * a) + 32;

        }

         private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            a = 5 / 9*(b - 32);
        }
    }
}
