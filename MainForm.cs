using FatCalculator.Calculator;
using FatCalculator.Sex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbWaistLine_TextChanged(object sender, EventArgs e)
        {
            this.onBFRChanged();
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            this.onBMIChanged();
        }
        private void tbTotalWeight_TextChanged(object sender, EventArgs e)
        {
            this.onBFRChanged();
            this.onBMIChanged();
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.onBFRChanged();
            this.onBMIChanged();
        }

        private void onBFRChanged()
        {
            if (String.IsNullOrEmpty(this.tbWaistLine.Text))
            {
                return;
            }
            decimal totalWeight;
            if (!Decimal.TryParse(this.tbTotalWeight.Text, out totalWeight))
            {
                return;
            }
            decimal waistLine;
            if (!Decimal.TryParse(this.tbWaistLine.Text, out waistLine))
            {
                return;
            }
            IScale4BFR scale;
            if (String.Equals(this.cbSex.SelectedItem, "男"))
            {
                scale = new Male();
            }
            else if (String.Equals(this.cbSex.SelectedItem, "女"))
            {
                scale = new Female();
            }
            else
            {
                return;
            }
            var bfr = new BFR(scale)
            {
                TotalWeight = totalWeight,
                WaistLine = waistLine
            };
            this.tbBFR.Text = bfr.run().ToString();
        }

        private void onBMIChanged()
        {
            if (String.IsNullOrEmpty(this.tbHeight.Text))
            {
                return;
            }
            decimal totalWeight;
            if (!Decimal.TryParse(this.tbTotalWeight.Text, out totalWeight))
            {
                return;
            }
            decimal height;
            if (!Decimal.TryParse(this.tbHeight.Text, out height))
            {
                return;
            }
            IScale4SW scale;
            if (String.Equals(this.cbSex.SelectedItem, "男"))
            {
                scale = new Male();
            }
            else if (String.Equals(this.cbSex.SelectedItem, "女"))
            {
                scale = new Female();
            }
            else
            {
                return;
            }
            var sw = new StandardWeight(scale)
            {
                TotalWeight = totalWeight,
                Height = height
            };
            this.tbStandardWeightPercent.Text = sw.run().ToString();
            this.tbStandardWeight.Text = sw.StandardWight.ToString();

            var bmi = new BMI()
            {
                TotalWeight = totalWeight,
                Height = height
            };
            this.tbBMI.Text = bmi.run().ToString();
        }
    }
}
