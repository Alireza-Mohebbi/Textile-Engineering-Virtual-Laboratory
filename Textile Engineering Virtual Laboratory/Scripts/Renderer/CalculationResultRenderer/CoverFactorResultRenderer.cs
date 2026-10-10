using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class CoverFactorResultRenderer : IRenderer
{
    public void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Cover Factor Calculated Parameters:",
            new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black,
            20,
            20);

        g.DrawString(
            "\nCover factor in warp direction = " + weave.CoverFactorInWarpDirection,
            new Font("Arial", 10),
            Brushes.Black,
            20,
            60);

        g.DrawString(
            "\nCover factor in weft direction = " + weave.CoverFactorInWeftDirection,
            new Font("Arial", 10),
            Brushes.Black,
            500,
            60);
    }
}