using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class PorosityResultCalculator : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Calculated Parameters:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "\nFabric Volume = " + Math.Round(weave.FabricVolume, decimalPlaces) + "mm^3" +
            "\nPorosity Volume = " + Math.Round(weave.PorosityVolume, decimalPlaces) + "mm^3" +
            "\nPorosity Percentage = " + Math.Round(weave.PorosityPercentage, decimalPlaces) + "%",
            textFont,
            textColor,
            20,
            60);
    }
}