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
        private double inflationRate;

        public Investment(double initialInvestment, double rateOfGrowth, int yearsOfGrowth, double inflationRate)
        {
            this.initialInvestment = initialInvestment;
            this.rateOfGrowth = rateOfGrowth;
            this.yearsOfGrowth = yearsOfGrowth;
            this.inflationRate = inflationRate;
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

        public double InflationRate
        {
            get 
            { 
                return inflationRate; 
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Inflation rate must be between 0 and 100.");
                }
                inflationRate = value;
            }
        }

        public List<(int year, double investmentValue, double realValue)> GetYearlyInvestmentDetails()
        {
            List<(int, double, double)> yearlyDetails = new List<(int, double, double)>();

            double currentInvestment = InitialInvestment;
            for (int year = 1; year <= YearsOfGrowth; year++)
            {
                currentInvestment += currentInvestment * (RateOfGrowth / 100);

                double inflationAdjustedValue = currentInvestment / Math.Pow(1 + InflationRate / 100, year);

                yearlyDetails.Add((year, currentInvestment, inflationAdjustedValue));
            }

            return yearlyDetails;
        }
    }
}
