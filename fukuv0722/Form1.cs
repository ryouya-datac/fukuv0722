using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0722
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left += int.Parse(textBox1.Text);
            label2.Top += int.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top - 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left + 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left - 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
