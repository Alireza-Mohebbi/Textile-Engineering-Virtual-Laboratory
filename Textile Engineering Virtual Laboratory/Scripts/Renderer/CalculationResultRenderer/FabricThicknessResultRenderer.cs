using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class FabricThicknessResultRenderer : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Fabric Thickness:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "\nFabric Thickness = " + weave.FabricThickness + "mm",
            textFont,
            textColor,
            20,
            60);
    }
}
