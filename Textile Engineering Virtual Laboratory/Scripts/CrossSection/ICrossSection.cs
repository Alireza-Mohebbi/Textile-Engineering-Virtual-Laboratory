using System;
using System.Drawing;

namespace TextileEngineeringVirtualLaboratory.CrossSection
{
    public interface ICrossSection
    {
        // Overall dimensions of the cross-section.
        float Width { get; }
        float Height { get; }

        // Returns a point on the boundary.
        // The origin is at the center of the shape.
        PointF GetPoint(double t);

        // Parameter interval for one complete boundary.
        double TStart { get; }
        double TEnd { get; }
    }
}