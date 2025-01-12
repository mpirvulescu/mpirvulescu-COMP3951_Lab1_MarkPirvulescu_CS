using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Investment
    {

        private double initialInvestment;
        private double rateOfGrowth;
        private int yearsOfGrowth;

        public Investment(double initialInvestment, double rateOfGrowth, int yearsOfGrowth)
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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Initial investment cannot be negative.");
                }
                initialInvestment = value;
            }
        }

        public double RateOfGrowth
        {
            get 
            { 
                return rateOfGrowth; 
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Rate of growth must be between 0 and 100.");
                }
                rateOfGrowth = value;
            }
        }

        public int YearsOfGrowth
        {
            get 
            { 
                return yearsOfGrowth; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Years of growth cannot be negative.");
                }
                yearsOfGrowth = value;
            }
        }

        public double CalculateInvestmentReturn()
        {
            // Compound interest formula: A = P * (1 + r/100)^t
            return InitialInvestment * Math.Pow(1 + RateOfGrowth / 100, YearsOfGrowth);
        }
    }
}
