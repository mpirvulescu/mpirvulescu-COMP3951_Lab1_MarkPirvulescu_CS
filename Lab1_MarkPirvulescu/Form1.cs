using System;
using System.Windows.Forms;

namespace InvestmentCalculator
{
    public partial class Form1 : Form
    {

        Investment myInvestment;
        string errorMessagesInitialInvestmentBox = "Please enter the investment value\n";
        string errorMessageRateOfGrowthBox = "Please enter a value for the rate of growth\n";
        string errorMessageYearsOfGrowthBox = "Please enter a value for the number of years\n";

        public Form1()
        {
            InitializeComponent();

            Center_Control(label1);
            Center_Control(label2);
            Center_Control(label3);
            Center_Control(Initial_Investment_Box);
            Center_Control(Rate_Of_Growth_Box);
            Center_Control(Years_Of_Growth_Box);
            Center_Control(Calculate_Button);
            Center_Control(Compound_Interest_Result_Box);
            this.myInvestment = new Investment(0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Initial_Investment_Box_Leave(object sender, EventArgs e)
        {
            //if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                double parsedValue;
                bool isValid = Double.TryParse(Initial_Investment_Box.Text, out parsedValue);
                if (isValid)
                {
                    myInvestment.InitialInvestment = parsedValue;
                    errorMessagesInitialInvestmentBox = "";
                }
                else
                {
                    errorMessagesInitialInvestmentBox = "Initial Investment must be a positive number.\n";
                }
            }
        }

        private void Rate_Of_Growth_Box_Leave(object sender, EventArgs e)
        {
            //if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                double parsedValue;
                bool isValid = Double.TryParse(Rate_Of_Growth_Box.Text, out parsedValue);
                if (isValid)
                {
                    myInvestment.RateOfGrowth = parsedValue;
                    errorMessageRateOfGrowthBox = "";
                }
                else
                {
                    errorMessageRateOfGrowthBox = "Rate of Growth must be between 0 and 100.\n";
                }
            }
        }

        private void Years_Of_Growth_Box_Leave(object sender, EventArgs e)
        {
            //if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                int parsedValue;
                bool isValid = int.TryParse(Years_Of_Growth_Box.Text, out parsedValue);
                if (isValid)
                {
                    myInvestment.YearsOfGrowth = parsedValue;
                    errorMessageYearsOfGrowthBox = "";
                }
                else
                {
                    errorMessageYearsOfGrowthBox = "Years of Growth must be a positive integer.\n";
                }
            }
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            string errorMessages = errorMessagesInitialInvestmentBox + errorMessageRateOfGrowthBox + errorMessageYearsOfGrowthBox;
            if (!string.IsNullOrEmpty(errorMessages))
            {
                MessageBox.Show(errorMessages, "Input Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double finalAmount = myInvestment.CalculateInvestmentReturn();
                Compound_Interest_Result_Box.Text = $"After {myInvestment.YearsOfGrowth} years, your investment will grow to {finalAmount:C}.";

                Center_Control(Compound_Interest_Result_Box);

            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Initial_Investment_Box.Text = "";
            Rate_Of_Growth_Box.Text = "";
            Years_Of_Growth_Box.Text = "";
            Compound_Interest_Result_Box.Text = "See your result here!";
            Center_Control(Compound_Interest_Result_Box);
            myInvestment = new Investment(0, 0, 0);
        }

        private void Center_Control(Control control)
        {
            int parentWidth = this.ClientSize.Width;
            int resultLabelWidth = control.Width;
            control.Location = new Point(
                (parentWidth - resultLabelWidth) / 2,
                control.Location.Y);
        }
    }  
}
