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

        private void button0_Click(object sender, EventArgs e)
        {
            long num = ar.increase(0);
            textBox.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num = ar.increase(1);
            textBox.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long num = ar.increase(2);
            textBox.Text = num.ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            long num = ar.increase(7);
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

        private void equals_Click(object sender, EventArgs e)
        {
            ar.Operation('=');
            updateTextBox();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            ar.Operation('+');
            //updateTextBox();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            ar.Operation('*');
            //updateTextBox();
        }

        private void division_Click(object sender, EventArgs e)
        {
            ar.Operation('/');
            //updateTextBox();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            ar.Operation('-');
            //updateTextBox();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ar.Clear();
            updateTextBox();
        }

        public void updateTextBox()
        {
            textBox.Text = ar.topNumber.ToString();
        }
    }
}
