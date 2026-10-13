using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class ArealWeightResultRenderer : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Fabric Areal Weight:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "\nFabric areal weight = " + Math.Round(weave.ArealWeight, decimalPlaces) + " g/cm^2",
            textFont,
            textColor,
            20,
            60);
    }
}
