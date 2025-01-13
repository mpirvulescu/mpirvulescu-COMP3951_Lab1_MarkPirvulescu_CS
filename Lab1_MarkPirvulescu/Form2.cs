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

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            // Clear existing rows and columns
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Add columns
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("InvestmentValue", "Investment Value");
            dataGridView1.Columns.Add("RealValue", "Real Value After Inflation");

            // Add rows based on the investment calculation
            double currentInvestment = myInvestment.InitialInvestment;
            double rateOfGrowth = myInvestment.RateOfGrowth / 100;
            //double inflationAdjustedValue = myInvestment.InflationRate / 100;

            var yearlyDetails = myInvestment.GetYearlyInvestmentDetails();

            // Add rows to DataGridView based on the investment details
            foreach (var detail in yearlyDetails)
            {
                dataGridView1.Rows.Add(detail.year, detail.investmentValue.ToString("C2"), detail.realValue.ToString("C2"));
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Activate();
            form1.Show();
        }
    }
}
