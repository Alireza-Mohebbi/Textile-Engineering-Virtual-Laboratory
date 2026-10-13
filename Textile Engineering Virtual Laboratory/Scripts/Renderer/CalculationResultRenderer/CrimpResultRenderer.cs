using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class CrimpResultRenderer : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Crimp Calculated Parameters:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "\nUnit cell crimp in warp direction = " + (weave.UnitCellCrimpInWarpsDirection * 100).ToString() + "%",
            textFont,
            textColor,
            20,
            60);

        g.DrawString(
            "\nUnit cell crimp in weft direction = " + (weave.UnitCellCrimpInWeftsDirection * 100).ToString() + "%",
            textFont,
            textColor,
            500,
            60);
    }
}
