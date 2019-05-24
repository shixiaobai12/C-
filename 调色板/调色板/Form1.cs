using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 调色板
{
    public partial class 调色板 : Form
    {
        public 调色板()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int a = rd.Next(0, 255);
            int b= rd.Next(0, 255);
            int c = rd.Next(0, 255);
            label1.BackColor = Color.FromArgb(a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
