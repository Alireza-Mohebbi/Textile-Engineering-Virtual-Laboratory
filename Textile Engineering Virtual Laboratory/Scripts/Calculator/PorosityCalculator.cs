using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    class PorosityCalculator : AbstractCalculator
    {
        private Weave weave;
        private Graphics g;
        private float fabricVolume;
        private float warpsVolume;
        float weftsVolume;
        float porosityVolume;
        float porosityPercentage;

        public override void Calculate(Weave weave, Graphics g)
        {
            this.weave = weave;
            this.g = g;

            fabricVolume = weave.FabricWidth * weave.FabricHeight * weave.FabricThickness;
            warpsVolume = (weave.RepeatX * weave.RepeatY * weave.SumOfWarpsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WarpDiameter, 2) / 4);
            weftsVolume = (weave.RepeatX * weave.RepeatY * weave.SumOfWeftsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WeftDiameter, 2) / 4);

            porosityVolume = fabricVolume - (warpsVolume + weftsVolume);
            porosityPercentage = (porosityVolume / fabricVolume) * 100;

            ShowResults();
        }

        protected override void ShowResults()
        {
            g.ResetTransform();

            g.DrawString(
                "Porosity Calculated Parameters:",
                new Font("Arial", 15, FontStyle.Bold),
                Brushes.Black,
                20,
                20);

            g.DrawString(
                "Fabric Volume = " + fabricVolume + "mm^3" +
                "\nPorosity Volume = " + porosityVolume + "mm^3" +
                "\nPorosity Percentage = " + porosityPercentage + "%",
                new Font("Arial", 10),
                Brushes.Black,
                20,
                60);
        }
    }
}