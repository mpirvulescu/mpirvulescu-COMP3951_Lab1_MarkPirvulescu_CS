using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentCalculator
{
    public partial class Form2 : Form
    {
        private Investment myInvestment;
        private Form form1;
        public Form2(Investment investment, Form form1)
        {
            InitializeComponent();
            this.myInvestment = investment;
            this.form1 = form1;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Activate();
            form1.Show();
        }
    }
}
