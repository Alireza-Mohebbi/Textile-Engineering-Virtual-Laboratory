using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class PorosityResultCalculator : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        g.DrawString(
            "Porosity Calculated Parameters:",
            titleFont,
            titleColor,
            20,
            20);

        g.DrawString(
            "Fabric Volume = " + weave.FabricVolume + "mm^3" +
            "\nPorosity Volume = " + weave.PorosityVolume + "mm^3" +
            "\nPorosity Percentage = " + weave.PorosityPercentage + "%",
            textFont,
            textColor,
            20,
            60);
    }
}