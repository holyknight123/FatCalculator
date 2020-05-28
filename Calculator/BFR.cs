using FatCalculator.Sex;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatCalculator.Calculator
{
    public class BFR : IFatCalculator
    {
        private IScale4BFR scale;
        public decimal WaistLine { get; set; }
        public decimal TotalWeight { get; set; }

        public BFR(IScale4BFR scale)
        {
            this.scale = scale;
        }

        public decimal run()
        {
            if (this.scale == null)
            {
                throw new ArgumentNullException("scale");
            }
            decimal weight = this.WaistLine * this.scale.WaistLineScale - this.TotalWeight * this.scale.TotalWeightScale - this.scale.TotalWeightConst;

            return Math.Round(weight * 100 / this.TotalWeight, 0);
        }
    }
}
