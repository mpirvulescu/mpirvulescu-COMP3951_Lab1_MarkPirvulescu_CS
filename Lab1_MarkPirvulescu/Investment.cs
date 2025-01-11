using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_MarkPirvulescu
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

        private static void ValidateInitialInvestment(double initialInvestment)
        {

        }

    }
}
