using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class CoverFactorResultRenderer : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Cover Factor Calculated Parameters:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "\nCover factor in warp direction = " + weave.CoverFactorInWarpDirection,
            textFont,
            textColor,
            20,
            60);

        g.DrawString(
            "\nCover factor in weft direction = " + weave.CoverFactorInWeftDirection,
            textFont,
            textColor,
            500,
            60);
    }
}