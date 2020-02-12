using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Arithmetic ar = new Arithmetic();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num = ar.increase(1);
            textBox.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            long num = ar.increase(7);
            textBox.Text = num.ToString();
        }

        private void Inv_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long num = ar.increase(2);
            textBox.Text = num.ToString();
        }

        private void equals_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long num = ar.increase(3);
            textBox.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long num = ar.increase(4);
            textBox.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            long num = ar.increase(5);
            textBox.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            long num = ar.increase(6);
            textBox.Text = num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            long num = ar.increase(8);
            textBox.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            long num = ar.increase(9);
            textBox.Text = num.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            long num = ar.increase(0);
            textBox.Text = num.ToString();
        }
    }
}
