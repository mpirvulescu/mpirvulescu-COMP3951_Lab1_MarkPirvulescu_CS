using System;
using System.Windows.Forms;

namespace InvestmentCalculator
{
    public partial class Form1 : Form
    {

        Investment myInvestment;
        string errorMessagesInitialInvestmentBox;
        string errorMessageRateOfGrowthBox;
        string errorMessageYearsOfGrowthBox;

        public Form1()
        {
            InitializeComponent();
            Initialize_Error_Messages();
            this.myInvestment = new Investment(0, 0, 0);
            Center_Control(label1);
            Center_Control(label2);
            Center_Control(label3);
            Center_Control(Initial_Investment_Box);
            Center_Control(Rate_Of_Growth_Box);
            Center_Control(Years_Of_Growth_Box);
            Center_Control(Calculate_Button);
        }

        private void Form1_Activate(object sender, EventArgs e)
        {
        }

        public virtual void OnShown(EventArgs e)
        {
            Initialize_Error_Messages();
            this.myInvestment = new Investment(0, 0, 0);
            Initial_Investment_Box.Text = "";
            Rate_Of_Growth_Box.Text = "";
            Years_Of_Growth_Box.Text = "";
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
                if (!string.IsNullOrEmpty(errorMessagesInitialInvestmentBox))
                {
                    Initial_Investment_Box.Text = "";
                }
                if (!string.IsNullOrEmpty(errorMessageRateOfGrowthBox))
                {
                    Rate_Of_Growth_Box.Text = "";
                }
                if (!string.IsNullOrEmpty(errorMessageYearsOfGrowthBox))
                {
                    Years_Of_Growth_Box.Text = "";
                }
                return;
            }
            else
            {
                Form2 graphForm = new Form2(myInvestment, this);
                graphForm.Show();
                Hide();
            }
        }

        

        private void Center_Control(Control control)
        {
            int parentWidth = this.ClientSize.Width;
            int resultLabelWidth = control.Width;
            control.Location = new Point(
                (parentWidth - resultLabelWidth) / 2,
                control.Location.Y);
        }

        private void Initialize_Error_Messages()
        {
             errorMessagesInitialInvestmentBox = "Please enter the investment value\n";
             errorMessageRateOfGrowthBox = "Please enter a value for the rate of growth\n";
             errorMessageYearsOfGrowthBox = "Please enter a value for the number of years\n";
        }
    }  
}
