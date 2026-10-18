using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class CoverFactorResultRenderer : AbstractRenderer
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
            "\nCover factor in warp direction = " + Math.Round(weave.CoverFactorInWarpDirection, decimalPlaces) + " / 28",
            textFont,
            textColor,
            20,
            60);

        g.DrawString(
            "\nCover factor in weft direction = " + Math.Round(weave.CoverFactorInWeftDirection, decimalPlaces) + " / 28",
            textFont,
            textColor,
            500,
            60);
    }
}