using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class CrimpResultRenderer : IRenderer
{
    public void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Crimp Calculated Parameters:",
            new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black,
            20,
            20);

        g.DrawString(
            "\nUnit cell crimp in warp direction = " + weave.UnitCellCrimpInWarpsDirection.ToString() + "%",
            new Font("Arial", 10),
            Brushes.Black,
            20,
            60);

        g.DrawString(
            "\nUnit cell crimp in weft direction = " + weave.UnitCellCrimpInWeftsDirection.ToString() + "%",
            new Font("Arial", 10),
            Brushes.Black,
            500,
            60);
    }
}
