using System;
using System.Collections.Generic;

namespace InvestmentCalculator
{
    /// <summary>
    /// Represents an investment with initial investment, rate of growth, years of growth, and inflation rate.
    /// </summary>
    public class Investment
    {
        // Private fields to store investment details
        private double initialInvestment;
        private double rateOfGrowth;
        private int yearsOfGrowth;
        private double inflationRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Investment"/> class.
        /// </summary>
        /// <param name="initialInvestment">The initial investment amount.</param>
        /// <param name="rateOfGrowth">The rate of growth as a percentage.</param>
        /// <param name="yearsOfGrowth">The number of years of growth.</param>
        /// <param name="inflationRate">The inflation rate as a percentage.</param>
        public Investment(double initialInvestment, double rateOfGrowth, int yearsOfGrowth, double inflationRate)
        {
            this.initialInvestment = initialInvestment;
            this.rateOfGrowth = rateOfGrowth;
            this.yearsOfGrowth = yearsOfGrowth;
            this.inflationRate = inflationRate;
        }

        /// <summary>
        /// Gets or sets the initial investment amount.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is negative.</exception>
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

        /// <summary>
        /// Gets or sets the rate of growth as a percentage.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not between 0 and 100.</exception>
        public double RateOfGrowth
        {
            get
            {
                return rateOfGrowth;
            }
            set
            {
                if (value < InvestmentCalculatorConstants.MinRateOfGrowth || value > InvestmentCalculatorConstants.MaxRateOfGrowth)
                {
                    throw new ArgumentException($"Rate of growth must be between {InvestmentCalculatorConstants.MinRateOfGrowth} and {InvestmentCalculatorConstants.MaxRateOfGrowth}.");
                }
                rateOfGrowth = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of years of growth.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is negative.</exception>
        public int YearsOfGrowth
        {
            get
            {
                return yearsOfGrowth;
            }
            set
            {
                if (value < InvestmentCalculatorConstants.MinYearsOfGrowth)
                {
                    throw new ArgumentException("Years of growth cannot be negative.");
                }
                yearsOfGrowth = value;
            }
        }

        /// <summary>
        /// Gets or sets the inflation rate as a percentage.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not between 0 and 100.</exception>
        public double InflationRate
        {
            get
            {
                return inflationRate;
            }
            set
            {
                if (value < InvestmentCalculatorConstants.MinInflationRate || value > InvestmentCalculatorConstants.MaxInflationRate)
                {
                    throw new ArgumentException($"Inflation rate must be between {InvestmentCalculatorConstants.MinInflationRate} and {InvestmentCalculatorConstants.MaxInflationRate}.");
                }
                inflationRate = value;
            }
        }

        /// <summary>
        /// Gets the yearly investment details including inflation adjustment.
        /// </summary>
        /// <returns>A list of tuples containing the year, investment value, and inflation-adjusted value.</returns>
        public List<(int year, double investmentValue, double realValue)> GetYearlyInvestmentDetails()
        {
            // List to store yearly investment details
            List<(int, double, double)> yearlyDetails = new List<(int, double, double)>();

            // Initialize the current investment with the initial investment amount
            double currentInvestment = InitialInvestment;
            for (int year = 1; year <= YearsOfGrowth; year++)
            {
                // Calculate the investment value for the current year
                currentInvestment += currentInvestment * (RateOfGrowth / 100);

                // Calculate the inflation-adjusted value
                double inflationAdjustedValue = currentInvestment / Math.Pow(1 + InflationRate / 100, year);

                // Add the details to the list
                yearlyDetails.Add((year, currentInvestment, inflationAdjustedValue));
            }

            return yearlyDetails;
        }
    }
}
