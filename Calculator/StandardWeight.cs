using FatCalculator.Sex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatCalculator.Calculator
{
    public class StandardWeight : IFatCalculator
    {
        private IScale4SW scale;
        public decimal Height { get; set; }
        public decimal TotalWeight { get; set; }

        public decimal StandardWight { get; private set; }

        public StandardWeight(IScale4SW scale)
        {
            this.scale = scale;
        }

        public decimal run()
        {
            if (this.scale == null)
            {
                throw new ArgumentNullException("scale");
            }
            this.StandardWight = (this.Height - this.scale.HeightScale) * this.scale.TotalWeightScale;

            return Math.Round(this.TotalWeight * 100 / this.StandardWight - 100, 1);
        }
    }
}
