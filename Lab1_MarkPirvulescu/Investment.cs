using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Investment
    {

        private readonly double initialInvestment;
        private readonly double rateOfGrowth;
        private readonly double yearsOfGrowth;

        public Investment(double initialInvestment, double rateOfGrowth, double yearsOfGrowth)
        {
            this.initialInvestment = initialInvestment;
            this.rateOfGrowth = rateOfGrowth;
            this.yearsOfGrowth = yearsOfGrowth;
        }

        public double InitialInvestment
        {
            get
            {
                return initialInvestment;
            }
            private set
            {
                if (initialInvestment < 0)
                {
                    MessageBox.Show("Initial investment cannot be lower than $0.00");
                }
            }
        }
    }
}
