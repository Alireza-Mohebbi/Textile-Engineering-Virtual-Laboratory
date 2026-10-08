using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class FabricThicknessResultRenderer : IRenderer
{
    public void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Fabric Thickness:",
            new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black,
            20,
            20);

        g.DrawString(
            "\nFabric Thickness = " + weave.FabricThickness + "mm",
            new Font("Arial", 10),
            Brushes.Black,
            20,
            60);
    }
}
