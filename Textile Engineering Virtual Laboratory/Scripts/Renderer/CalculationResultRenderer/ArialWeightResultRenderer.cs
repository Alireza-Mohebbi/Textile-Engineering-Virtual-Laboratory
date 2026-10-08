using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class ArialWeightRenderer : IRenderer
{
    public void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Fabric Arial Weight:",
            new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black,
            20,
            20);

        g.DrawString(
            "\nFabric arial weight = " + weave.ArialWeight + "g/mm^2",
            new Font("Arial", 10),
            Brushes.Black,
            20,
            60);
    }
}
