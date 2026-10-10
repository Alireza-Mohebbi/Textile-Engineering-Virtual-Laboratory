using System;
using System.Drawing;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Simulator;
using TextileEngineeringVirtualLaboratory.Textiles;

public partial class DrapeSimulator : AbstractSimulator
{
    private Weave weave;
    private float bendingRigidity;          // (N/mm^2)
    private float arealWeight;             // (Kg/mm^2) 
    private float length;                   // (mm)
    private float secondMomentOfInertia;    // (mm^4)

    public DrapeSimulator(Weave weave)
    {
        this.weave = weave;
        secondMomentOfInertia = weave.FabricWidth * (float)Math.Pow(weave.FabricThickness, 3) / 12;
        bendingRigidity = weave.YoungsModulusY * secondMomentOfInertia;
        arealWeight = weave.ArealWeight;
        length = weave.FabricHeight;
    }

    // Note: These calculations are with respect to the warp direction of the fabric
    // If the drape in weft direction is desired, new calculations should be implemented
    public override void Simulate(Graphics g)
    {
        PointF[] points = new PointF[axesRange];

        for (int x = 0; x < axesRange; x++)
        {
            float y = ((arealWeight * x * x) / (24 * bendingRigidity)) * ((6 * length * length) - (4 * length * x) + (x * x));
            points[x] = new PointF(x, y);
        }

        try
        {
            PointF clampWallStartPoint = new PointF(points[0].X, points[0].Y - 20);
            PointF clampWallEndPoint = new PointF(points[0].X, points[0].Y + 20);

            g.TranslateTransform(60, 600);
            g.ScaleTransform(displayScale, displayScale);
            g.DrawCurve(Pens.Blue, points);
            g.DrawLine(Pens.Black, clampWallStartPoint, clampWallEndPoint);
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid values. Please check the inputs.");
        }

        // Textual info
        g.ResetTransform();
        g.DrawString("Drape 2D Calculated Parameteres:", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 20, 20);
        g.DrawString("Bending Rigidity (N/mm^2) = " + bendingRigidity.ToString(), new Font("Arial", 10), Brushes.Black, 20, 60);
        g.DrawString("Fabric Areal Density (Kg/mm^2) = " + arealWeight.ToString(), new Font("Arial", 10), Brushes.Black, 20, 80);
        g.DrawString("Fabric Length (mm) = " + length.ToString("0.000"), new Font("Arial", 10), Brushes.Black, 20, 100);
    }
}