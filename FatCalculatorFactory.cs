using FatCalculator.Calculator;
using FatCalculator.Sex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatCalculator
{
    public class FatCalculatorFactory
    {
        public static IFatCalculator getBFR(IScale4BFR scale)
        {
            return new BFR(scale);
        }
        public static IFatCalculator getBMI()
        {
            return new BMI();
        }

        public static IFatCalculator getStandardWeight(IScale4SW scale)
        {
            return new StandardWeight(scale);
        }
    }
}
