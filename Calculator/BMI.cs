using FatCalculator.Sex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatCalculator.Calculator
{
    public class BMI : IFatCalculator
    {
        public decimal Height { get; set; }
        public decimal TotalWeight { get; set; }

        public decimal run()
        {
            decimal height = this.Height * 0.01m;
            
            return Math.Round(this.TotalWeight / (height * height), 1);
        }
    }
}
