using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class PorosityResultCalculator : IRenderer
{
    public void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Porosity Calculated Parameters:",
            new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black,
            20,
            20);

        g.DrawString(
            "Fabric Volume = " + weave.FabricVolume + "mm^3" +
            "\nPorosity Volume = " + weave.PorosityVolume + "mm^3" +
            "\nPorosity Percentage = " + weave.PorosityPercentage + "%",
            new Font("Arial", 10),
            Brushes.Black,
            20,
            60);
    }
}