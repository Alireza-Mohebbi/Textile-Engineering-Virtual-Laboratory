using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

class ResultWindowRenderer : AbstractRenderer
{
    public override void Draw(Weave weave, Graphics g)
    {
        g.ResetTransform();

        // Title
        g.DrawString(
            "Calculated Parameters:",
            titleFont,
            titleColor,
            20,
            20);

        // Fabric thickness
        g.DrawString(
            "\nFabric Thickness = " + Math.Round(weave.FabricThickness, decimalPlaces) + "mm",
            textFont,
            textColor,
            20,
            70);

        // Crimp
        g.DrawString(
            "\nUnit cell crimp in warp direction = " + Math.Round(weave.UnitCellCrimpInWarpDirection * 100, decimalPlaces).ToString() + "%",
            textFont,
            textColor,
            20,
            110);

        g.DrawString(
            "\nUnit cell crimp in weft direction = " + Math.Round(weave.UnitCellCrimpInWeftDirection * 100, decimalPlaces).ToString() + "%",
            textFont,
            textColor,
            500,
            110);

        // Porosity
        g.DrawString(
            "\nFabric Volume = " + Math.Round(weave.FabricVolume, decimalPlaces) + "mm^3" +
            "\nPorosity Volume = " + Math.Round(weave.PorosityVolume, decimalPlaces) + "mm^3" +
            "\nPorosity Percentage = " + Math.Round(weave.PorosityPercentage, decimalPlaces) + "%",
            textFont,
            textColor,
            20,
            150);

        // Cover factor
        g.DrawString(
            "\nCover factor in warp direction = " + Math.Round(weave.CoverFactorInWarpDirection, decimalPlaces) + " / 28",
            textFont,
            textColor,
            20,
            190);

        g.DrawString(
            "\nCover factor in weft direction = " + Math.Round(weave.CoverFactorInWeftDirection, decimalPlaces) + " / 28",
            textFont,
            textColor,
            500,
            190);

        // Areal weight
        g.DrawString(
            "\nFabric areal weight = " + Math.Round(weave.ArealWeight, decimalPlaces) + " g/m^2",
            textFont,
            textColor,
            20,
            230);

        // Required yarn length for fabric
    }
}
