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
    /// <summary>
    /// Represents the form that displays the investment details in a DataGridView.
    /// </summary>
    public partial class Form2 : Form
    {
        // Instance of the Investment class
        private Investment myInvestment;

        // Reference to the first form
        private Form form1;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form2"/> class.
        /// </summary>
        /// <param name="investment">The investment details to display.</param>
        /// <param name="form1">The reference to the first form.</param>
        public Form2(Investment investment, Form form1)
        {
            InitializeComponent();
            this.myInvestment = investment;
            this.form1 = form1;

            // Populate the DataGridView with investment details
            PopulateDataGridView();
        }

        /// <summary>
        /// Populates the DataGridView with yearly investment details.
        /// </summary>
        private void PopulateDataGridView()
        {
            // Clear existing columns and rows
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("InvestmentValue", "Investment Value");
            dataGridView1.Columns.Add("RealValue", "Real Value After Inflation");

            // Get the yearly investment details
            var yearlyDetails = myInvestment.GetYearlyInvestmentDetails();

            // Add rows to the DataGridView
            foreach (var detail in yearlyDetails)
            {
                dataGridView1.Rows.Add(detail.year, detail.investmentValue.ToString("C2"), detail.realValue.ToString("C2"));
            }
        }

        /// <summary>
        /// Event handler for the Reset button click.
        /// Closes the current form and reactivates the first form.
        /// </summary>
        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Activate();
            form1.Show();
        }
    }
}

