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

        public override void Calculate(Weave weave)
        {
            this.weave = weave;

            float fabricVolume = weave.FabricWidth * weave.FabricHeight * weave.FabricThickness;
            float warpsVolume = (weave.RepeatX * weave.RepeatY * weave.SumOfWarpsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WarpThickness, 2) / 4);
            float weftsVolume = (weave.RepeatX * weave.RepeatY * weave.SumOfWeftsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WeftThickness, 2) / 4);

            float porosityVolume = fabricVolume - (warpsVolume + weftsVolume);
            float porosityPercentage = (porosityVolume / fabricVolume) * 100;

            MessageBox.Show(
                "Fabric Volume = " + fabricVolume + "mm^3" +
                "\nPorosity Volume = " + porosityVolume + "mm^3" +
                "\nPorosity Percentage = " + porosityPercentage + "%");
        }

    }
}