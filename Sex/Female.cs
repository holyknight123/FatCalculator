using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatCalculator.Sex
{
    public class Female : IScale4BFR, IScale4SW
    {
        public decimal WaistLineScale => 0.74m;

        decimal IScale4BFR.TotalWeightScale => 0.082m;

        public decimal TotalWeightConst => 34.89m;

        public decimal HeightScale => 70m;

        decimal IScale4SW.TotalWeightScale => 0.6m;
    }
}
