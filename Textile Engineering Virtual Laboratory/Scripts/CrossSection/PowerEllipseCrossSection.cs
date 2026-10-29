using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.CrossSection;

public sealed class PowerEllipseCrossSection : ICrossSection
{
    public float Width { get; }
    public float Height { get; }

    public double Exponent { get; }

    public PowerEllipseCrossSection(
        float width,
        float height,
        double exponent)
    {
        if (width <= 0 || height <= 0 || exponent <= 0)
            throw new ArgumentException(
                "Dimensions and exponent must be positive.");

        Width = width;
        Height = height;
        Exponent = exponent;
    }

    public double TStart => 0;
    public double TEnd => 2 * Math.PI;

    public PointF GetPoint(double t)
    {
        double cos = Math.Cos(t);
        double sin = Math.Sin(t);

        double x = Width / 2.0 *
            Math.Sign(cos) *
            Math.Pow(Math.Abs(cos), 2.0 / Exponent);

        double y = Height / 2.0 *
            Math.Sign(sin) *
            Math.Pow(Math.Abs(sin), 2.0 / Exponent);

        return new PointF((float)x, (float)y);
    }
}