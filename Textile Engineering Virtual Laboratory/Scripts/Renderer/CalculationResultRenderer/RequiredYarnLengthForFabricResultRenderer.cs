using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class RequiredYarnLengthForFabricResultRenderer : AbstractRenderer
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
            "\nRequired Yarn Length for the Fabric = " + (Math.Round(weave.RequiredWarpLengthForFabric + weave.RequiredWeftLengthForFabric, decimalPlaces)) + " m",      // (m)
            textFont,
            textColor,
            20,
            60);
    }
}