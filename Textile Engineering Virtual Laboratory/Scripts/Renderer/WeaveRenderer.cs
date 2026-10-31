using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using TextileEngineeringVirtualLaboratory.CrossSection;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

public class WeaveRenderer : AbstractRenderer
{
    private Weave weave;
    private Graphics g;

    public override void Draw(Weave weave, Graphics g)
    {
        if (weave == null || g == null)
        {
            return;
        }

        this.weave = weave;
        this.g = g;

        DrawTopView();
        DrawCrossSection();
    }

    private void DrawTopView()
    {
        using (Pen warpPen = new Pen(Color.Red, weave.WarpDiameter))
        using (Pen weftPen = new Pen(Color.Blue, weave.WeftDiameter))
        {
            // Draw warps
            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                g.DrawLine(warpPen, i * weave.WarpSpacing + weave.WarpSpacing / 2, 0, i * weave.WarpSpacing + weave.WarpSpacing / 2, weave.UnitCellLengthInWarpDirection);
            }

            // Draw wefts
            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                g.DrawLine(weftPen, 0, i * weave.WeftSpacing + weave.WeftSpacing / 2, weave.UnitCellLengthInWeftDirection, i * weave.WeftSpacing + weave.WeftSpacing / 2);
            }

            // Draw interlacements
            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                for (int j = 0; j < weave.NumberOfWefts; j++)
                {
                    float interlacementCenterX = i * weave.WarpSpacing + weave.WarpSpacing / 2f;
                    float interlacementCenterY = j * weave.WeftSpacing + weave.WeftSpacing / 2f;

                    float interlacementBoundingBoxLeft = interlacementCenterX - weave.WarpDiameter / 2f;
                    float interlacementBoundingBoxTop = interlacementCenterY - weave.WarpDiameter / 2f;

                    RectangleF warpInterlacementBoundingBox = new RectangleF(interlacementBoundingBoxLeft, interlacementBoundingBoxTop, weave.WarpDiameter * 1.01f, weave.WarpDiameter * 1.01f);
                    RectangleF weftInterlacementBoundingBox = new RectangleF(interlacementBoundingBoxLeft, interlacementBoundingBoxTop, weave.WeftDiameter * 1.01f, weave.WeftDiameter * 1.01f);

                    if (weave.IsWarpOverWeft[i, j])
                    {
                        g.FillRectangle(Brushes.Red, warpInterlacementBoundingBox);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Blue, weftInterlacementBoundingBox);
                    }
                }
            }
        }
    }


    private const int BoundarySamples = 720;   // resolution of the warp outline
    private const int SamplesPerSpacing = 32;  // weft path resolution per warp spacing (keep even)

    private void DrawCrossSection()
    {
        ICrossSection section = weave.CrossSection;
        int warpCount = weave.NumberOfWarps;

        if (section == null || warpCount <= 0)
        {
            return;
        }

        int bottomRow = weave.NumberOfWefts - 1;
        double weftRadius = weave.WeftDiameter / 2.0;

        // 1. Warp outline (relative to the shape's own origin).
        PointF[] shape = SampleBoundary(section);

        float shapeMinY = float.MaxValue;
        float shapeMaxY = float.MinValue;
        double shapeHalfWidth = 0;

        foreach (PointF p in shape)
        {
            shapeMinY = Math.Min(shapeMinY, p.Y);
            shapeMaxY = Math.Max(shapeMaxY, p.Y);
            shapeHalfWidth = Math.Max(shapeHalfWidth, Math.Abs(p.X));
        }

        double warpHeight = shapeMaxY - shapeMinY;
        double thickness = warpHeight + weave.WeftDiameter;

        // 2. Vertical placement of each warp inside the local band [0, thickness].
        //    Warp over weft  -> warp touches the bottom of the band.
        //    Warp under weft -> warp touches the top of the band.
        bool[] over = new bool[warpCount];
        double[] warpCenterY = new double[warpCount];

        for (int i = 0; i < warpCount; i++)
        {
            over[i] = weave.IsWarpOverWeft[i, bottomRow];
            warpCenterY[i] = over[i]
                ? thickness - shapeMaxY
                : -shapeMinY;
        }

        // 3. Weft centre line (tight against every warp it must pass).
        List<PointF> weftPath = weftRadius > 0
            ? BuildWeftPath(shape, shapeHalfWidth, over, warpCenterY, weftRadius)
            : new List<PointF>();

        // 4. Find the real top of everything and shift so it is tangent
        //    to the bottom of the top view.
        double minY = double.MaxValue;

        for (int i = 0; i < warpCount; i++)
        {
            minY = Math.Min(minY, warpCenterY[i] + shapeMinY);
        }

        foreach (PointF p in weftPath)
        {
            minY = Math.Min(minY, p.Y - weftRadius);
        }

        float shift = (float)(weave.UnitCellLengthInWarpDirection - minY);

        GraphicsState state = g.Save();
        g.TranslateTransform(0f, shift);

        try
        {
            // Warps.
            using (Brush warpBrush = new SolidBrush(Color.Red))
            {
                PointF[] points = new PointF[shape.Length];

                for (int i = 0; i < warpCount; i++)
                {
                    float cx = i * weave.WarpSpacing + weave.WarpSpacing / 2f;
                    float cy = (float)warpCenterY[i];

                    for (int j = 0; j < shape.Length; j++)
                    {
                        points[j] = new PointF(cx + shape[j].X, cy + shape[j].Y);
                    }

                    g.FillPolygon(warpBrush, points);
                }
            }

            // Weft.
            if (weftPath.Count >= 2)
            {
                using (Pen weftPen = new Pen(Color.Blue, weave.WeftDiameter))
                {
                    weftPen.LineJoin = LineJoin.Round;
                    g.DrawLines(weftPen, weftPath.ToArray());
                }
            }
        }
        finally
        {
            g.Restore(state);
        }
    }

    /// <summary>Samples one full boundary of the cross-section.</summary>
    private static PointF[] SampleBoundary(ICrossSection section)
    {
        PointF[] pts = new PointF[BoundarySamples];

        for (int j = 0; j < BoundarySamples; j++)
        {
            double t = section.TStart
                + (section.TEnd - section.TStart) * j / BoundarySamples;

            pts[j] = section.GetPoint(t);
        }

        return pts;
    }

    /// <summary>
    /// Builds the weft centre line: the shortest path that stays at least
    /// one weft radius away from every warp (above warps that are "over",
    /// below warps that are "under"). Works for any warp shape.
    /// </summary>
    private List<PointF> BuildWeftPath(
        PointF[] shape,
        double shapeHalfWidth,
        bool[] over,
        double[] warpCenterY,
        double weftRadius)
    {
        int warpCount = over.Length;
        int m = SamplesPerSpacing;
        double step = weave.WarpSpacing / (double)m;

        int last = Math.Max(m, (int)Math.Round(weave.UnitCellLengthInWeftDirection / step));

        double[] xs = new double[last + 1];
        for (int k = 0; k <= last; k++)
        {
            xs[k] = k * step;
        }
        xs[last] = weave.UnitCellLengthInWeftDirection;

        // Offset envelope of the warp shape, relative to the warp centre.
        // upper[d]: highest the weft centre may be when ABOVE the warp (min Y)
        // lower[d]: lowest  the weft centre may be when BELOW the warp (max Y)
        int reach = (int)Math.Ceiling((shapeHalfWidth + weftRadius) / step);
        double[] upper = new double[2 * reach + 1];
        double[] lower = new double[2 * reach + 1];

        for (int d = -reach; d <= reach; d++)
        {
            double dx = d * step;
            double up = double.PositiveInfinity;
            double lo = double.NegativeInfinity;

            foreach (PointF q in shape)
            {
                double ddx = dx - q.X;
                if (Math.Abs(ddx) > weftRadius) continue;

                double h = Math.Sqrt(weftRadius * weftRadius - ddx * ddx);

                up = Math.Min(up, q.Y - h);
                lo = Math.Max(lo, q.Y + h);
            }

            upper[d + reach] = up;
            lower[d + reach] = lo;
        }

        // Allowed range of the weft centre at every sample: lo[k] <= y <= hi[k].
        double[] lo_ = new double[last + 1];
        double[] hi_ = new double[last + 1];

        for (int k = 0; k <= last; k++)
        {
            lo_[k] = double.NegativeInfinity;
            hi_[k] = double.PositiveInfinity;
        }

        for (int i = 0; i < warpCount; i++)
        {
            int c = i * m + m / 2;

            for (int d = -reach; d <= reach; d++)
            {
                int k = c + d;
                if (k < 0 || k > last) continue;

                if (over[i])
                {
                    double v = upper[d + reach];
                    if (!double.IsInfinity(v))
                        hi_[k] = Math.Min(hi_[k], warpCenterY[i] + v);
                }
                else
                {
                    double v = lower[d + reach];
                    if (!double.IsInfinity(v))
                        lo_[k] = Math.Max(lo_[k], warpCenterY[i] + v);
                }
            }
        }

        // Infeasible spots (warps too close for the weft): fall back to the middle.
        for (int k = 0; k <= last; k++)
        {
            if (lo_[k] > hi_[k])
            {
                double mid = (lo_[k] + hi_[k]) / 2.0;
                lo_[k] = mid;
                hi_[k] = mid;
            }
        }

        // Free ends: start/end at the first/last constrained level.
        double startY = 0, endY = 0;
        bool found = false;

        for (int k = 0; k <= last; k++)
        {
            if (!double.IsInfinity(lo_[k]) || !double.IsInfinity(hi_[k]))
            {
                startY = LevelOf(lo_[k], hi_[k]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            return new List<PointF>();
        }

        for (int k = last; k >= 0; k--)
        {
            if (!double.IsInfinity(lo_[k]) || !double.IsInfinity(hi_[k]))
            {
                endY = LevelOf(lo_[k], hi_[k]);
                break;
            }
        }

        lo_[0] = hi_[0] = startY;
        lo_[last] = hi_[last] = endY;

        // Shortest path through the corridor (taut string / funnel).
        List<PointF> path = new List<PointF>();
        int a = 0;
        double ay = startY;
        path.Add(new PointF((float)xs[0], (float)ay));

        while (a < last)
        {
            double ax = xs[a];
            double lowSlope = double.NegativeInfinity;
            double highSlope = double.PositiveInfinity;
            int lowIdx = a, highIdx = a;
            int next = last;
            double nextY = endY;

            for (int k = a + 1; k <= last; k++)
            {
                double dx = xs[k] - ax;
                double sLo = (lo_[k] - ay) / dx;
                double sHi = (hi_[k] - ay) / dx;

                if (sLo > highSlope)
                {
                    next = highIdx;
                    nextY = hi_[highIdx];
                    break;
                }

                if (sHi < lowSlope)
                {
                    next = lowIdx;
                    nextY = lo_[lowIdx];
                    break;
                }

                if (sLo > lowSlope) { lowSlope = sLo; lowIdx = k; }
                if (sHi < highSlope) { highSlope = sHi; highIdx = k; }
            }

            path.Add(new PointF((float)xs[next], (float)nextY));
            a = next;
            ay = nextY;
        }

        return path;
    }

    private static double LevelOf(double lo, double hi)
    {
        if (double.IsInfinity(lo)) return hi;
        if (double.IsInfinity(hi)) return lo;
        return (lo + hi) / 2.0;
    }
}