using System;
using System.Windows.Forms;

namespace InvestmentCalculator
{
    public partial class Form1 : Form
    {
        // Instance of the Investment class
        private Investment myInvestment;

        // Error message strings for various input fields
        private string errorMessagesInitialInvestmentBox = "";
        private string errorMessageRateOfGrowthBox = "";
        private string errorMessageYearsOfGrowthBox = "";
        private string errorMessageInflationAdjustmentBox = "";

        /// <summary>
        /// Constructor for Form1.
        /// Initializes the form components and centers the controls.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Initialize_Error_Messages();
            Center_Control(label1);
            Center_Control(label2);
            Center_Control(label3);
            Center_Control(label4);
            Center_Control(Initial_Investment_Box);
            Center_Control(Rate_Of_Growth_Box);
            Center_Control(Years_Of_Growth_Box);
            Center_Control(Calculate_Button);
            Center_Control(Inflation_Adjustment_Box);

            // Initialize the Investment instance with default values
            this.myInvestment = new Investment(0, 0, 0, 0);
        }

        /// <summary>
        /// Event handler for form activation.
        /// Clears input fields and reinitializes error messages.
        /// </summary>
        private void Form1_Activate(object sender, EventArgs e)
        {
            // Clear input fields
            Initial_Investment_Box.Text = "";
            Rate_Of_Growth_Box.Text = "";
            Years_Of_Growth_Box.Text = "";
            Inflation_Adjustment_Box.Text = "";

            // Reinitialize error messages
            Initialize_Error_Messages();

            // Reset the Investment instance
            this.myInvestment = new Investment(0, 0, 0, 0);
        }

        /// <summary>
        /// Event handler for when the Initial Investment input box loses focus.
        /// Validates the input and updates the Investment instance.
        /// </summary>
        private void Initial_Investment_Box_Leave(object sender, EventArgs e)
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

        /// <summary>
        /// Event handler for when the Rate of Growth input box loses focus.
        /// Validates the input and updates the Investment instance.
        /// </summary>
        private void Rate_Of_Growth_Box_Leave(object sender, EventArgs e)
        {
            double parsedValue;
            bool isValid = Double.TryParse(Rate_Of_Growth_Box.Text, out parsedValue);
            if (isValid)
            {
                if (parsedValue >= InvestmentCalculatorConstants.MinRateOfGrowth && parsedValue <= InvestmentCalculatorConstants.MaxRateOfGrowth)
                {
                    myInvestment.RateOfGrowth = parsedValue;
                    errorMessageRateOfGrowthBox = "";
                }
                else
                {
                    errorMessageRateOfGrowthBox = $"Rate of Growth must be between {InvestmentCalculatorConstants.MinRateOfGrowth} and {InvestmentCalculatorConstants.MaxRateOfGrowth}.\n";
                }
            }
            else
            {
                errorMessageRateOfGrowthBox = "Rate of Growth must be a valid number.\n";
            }
        }

        /// <summary>
        /// Event handler for when the Years of Growth input box loses focus.
        /// Validates the input and updates the Investment instance.
        /// </summary>
        private void Years_Of_Growth_Box_Leave(object sender, EventArgs e)
        {
            int parsedValue;
            bool isValid = int.TryParse(Years_Of_Growth_Box.Text, out parsedValue);
            if (isValid)
            {
                if (parsedValue >= InvestmentCalculatorConstants.MinYearsOfGrowth)
                {
                    myInvestment.YearsOfGrowth = parsedValue;
                    errorMessageYearsOfGrowthBox = "";
                }
                else
                {
                    errorMessageYearsOfGrowthBox = $"Years of Growth must be a positive integer.\n";
                }
            }
            else
            {
                errorMessageYearsOfGrowthBox = "Years of Growth must be a valid integer.\n";
            }
        }

        /// <summary>
        /// Event handler for the Calculate button click.
        /// Validates inputs and either shows error messages or proceeds to the graph form.
        /// </summary>
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            // Combine all error messages
            string errorMessages =
                errorMessagesInitialInvestmentBox +
                errorMessageRateOfGrowthBox +
                errorMessageYearsOfGrowthBox +
                errorMessageInflationAdjustmentBox;

            // If there are any error messages, show them in a message box
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
                if (!string.IsNullOrEmpty(errorMessageInflationAdjustmentBox))
                {
                    Inflation_Adjustment_Box.Text = "";
                }
                return;
            }
            else
            {
                // If no errors, create and show the graph form
                Form2 graphForm = new Form2(myInvestment, this);
                graphForm.Show();
                Hide();
            }
        }

        /// <summary>
        /// Method to center a control horizontally within the form.
        /// </summary>
        /// <param name="control">The control to be centered.</param>
        private void Center_Control(Control control)
        {
            int parentWidth = this.ClientSize.Width;
            int resultLabelWidth = control.Width;
            control.Location = new Point(
                (parentWidth - resultLabelWidth) / 2,
                control.Location.Y);
        }

        /// <summary>
        /// Method to initialize error messages.
        /// </summary>
        private void Initialize_Error_Messages()
        {
            errorMessagesInitialInvestmentBox = "Please enter a value for the initial investment\n";
            errorMessageRateOfGrowthBox = "Please enter a value for the rate of growth\n";
            errorMessageYearsOfGrowthBox = "Please enter a value for the number of years\n";
            errorMessageInflationAdjustmentBox = "Please enter a value for the inflation rate";
        }

        /// <summary>
        /// Event handler for when the Inflation Adjustment input box loses focus.
        /// Validates the input and updates the Investment instance.
        /// </summary>
        private void Inflation_Adjustment_Box_Leave(object sender, EventArgs e)
        {
            double parsedValue;
            bool isValid = Double.TryParse(Inflation_Adjustment_Box.Text, out parsedValue);
            if (isValid)
            {
                if (parsedValue >= InvestmentCalculatorConstants.MinInflationRate && parsedValue <= InvestmentCalculatorConstants.MaxInflationRate)
                {
                    myInvestment.InflationRate = parsedValue;
                    errorMessageInflationAdjustmentBox = "";
                }
                else
                {
                    errorMessageInflationAdjustmentBox = $"Inflation rate must be between {InvestmentCalculatorConstants.MinInflationRate} and {InvestmentCalculatorConstants.MaxInflationRate}%.\n";
                }
            }
            else
            {
                errorMessageInflationAdjustmentBox = "Inflation rate must be a valid number.\n";
            }
        }
    }
}
