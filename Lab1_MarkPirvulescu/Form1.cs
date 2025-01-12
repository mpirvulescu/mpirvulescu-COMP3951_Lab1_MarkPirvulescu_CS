using System;
using System.Windows.Forms;

namespace InvestmentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter the amount you want to invest";
            label2.Text = "Enter the rate at which this index is supposed to grow at";
            label3.Text = "Enter the amount of years of growth";
            button1.Text = "Calculate!";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
