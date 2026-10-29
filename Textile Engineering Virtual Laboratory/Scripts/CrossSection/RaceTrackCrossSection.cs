using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.CrossSection;

public sealed class RaceTrackCrossSection : ICrossSection
{
    public float Width { get; }
    public float Height { get; }

    public RaceTrackCrossSection(float width, float height)
    {
        if (width < height || height <= 0)
            throw new ArgumentException(
                "Require width >= height > 0.");

        Width = width;
        Height = height;
    }

    public double TStart => 0;
    public double TEnd => 2 * Math.PI;

    public PointF GetPoint(double t)
    {
        double r = Height / 2.0;
        double c = (Width - Height) / 2.0;

        double perimeter =
            2 * (Width - Height) + 2 * Math.PI * r;

        double s = t / (2 * Math.PI) * perimeter;

        double x, y;

        if (s < Width - Height)
        {
            // Top straight segment.
            x = -c + s;
            y = r;
        }
        else if ((s -= Width - Height) < Math.PI * r)
        {
            // Right semicircle.
            double angle = Math.PI / 2 - s / r;

            x = c + r * Math.Cos(angle);
            y = r * Math.Sin(angle);
        }
        else if ((s -= Math.PI * r) < Width - Height)
        {
            // Bottom straight segment.
            x = c - s;
            y = -r;
        }
        else
        {
            // Left semicircle.
            s -= Width - Height;

            double angle = -Math.PI / 2 - s / r;

            x = -c + r * Math.Cos(angle);
            y = r * Math.Sin(angle);
        }

        return new PointF((float)x, (float)y);
    }
}