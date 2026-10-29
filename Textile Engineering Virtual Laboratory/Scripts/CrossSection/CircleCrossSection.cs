using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.CrossSection;

public sealed class CircleCrossSection : ICrossSection
{
    public float Diameter { get; }

    public CircleCrossSection(float diameter)
    {
        if (diameter <= 0)
            throw new ArgumentOutOfRangeException(nameof(diameter));

        Diameter = diameter;
    }

    public float Width => Diameter;
    public float Height => Diameter;

    public double TStart => 0;
    public double TEnd => 2 * Math.PI;

    public PointF GetPoint(double t)
    {
        float r = Diameter / 2f;

        return new PointF(
            r * (float)Math.Cos(t),
            r * (float)Math.Sin(t));
    }
}
