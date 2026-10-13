using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class FabricThicknessResultRenderer : AbstractRenderer
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
            "\nFabric Thickness = " + Math.Round(weave.FabricThickness, decimalPlaces) + "mm",
            textFont,
            textColor,
            20,
            60);
    }
}
