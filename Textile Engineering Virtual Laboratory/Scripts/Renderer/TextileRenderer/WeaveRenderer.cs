using System;
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
                g.DrawLine(warpPen, i * weave.WarpSpacing + weave.WarpSpacing / 2, 0, i * weave.WarpSpacing + weave.WarpSpacing / 2, weave.FabricHeight);
            }

            // Draw wefts
            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                g.DrawLine(weftPen, 0, i * weave.WeftSpacing + weave.WeftSpacing / 2, weave.FabricWidth, i * weave.WeftSpacing + weave.WeftSpacing / 2);
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

    private void DrawCrossSection()
    {
        ICrossSection section = weave.CrossSection;

        int bottomRowWeftIndex = weave.NumberOfWefts - 1;
        float yOffset = weave.FabricThickness;

        using (Pen weftPen = new Pen(Color.Blue, weave.WeftDiameter))
        using (Brush warpBrush = new SolidBrush(Color.Red))
        {
            // +2 for the extra start and end points
            PointF[] weftPoints = new PointF[weave.NumberOfWarps + 2];

            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                float x = i * weave.WarpSpacing + weave.WarpSpacing / 2f;

                bool isWarpOverWeft =
                    weave.IsWarpOverWeft[i, bottomRowWeftIndex];

                float warpY;
                float weftY;

                if (isWarpOverWeft)
                {
                    warpY = weave.FabricHeight
                            - weave.WarpDiameter / 2f;

                    weftY = weave.FabricHeight
                            - weave.FabricThickness
                            + weave.WeftDiameter / 2f;
                }
                else
                {
                    warpY = weave.FabricHeight
                            - weave.FabricThickness
                            + weave.WarpDiameter / 2f;

                    weftY = weave.FabricHeight
                            - weave.WeftDiameter / 2f;
                }

                warpY += yOffset;
                weftY += yOffset;

                // Draw warp cross-section using the shape in Weave.
                PointF[] points = new PointF[101];

                for (int j = 0; j <= 100; j++)
                {
                    double t = section.TStart
                        + (section.TEnd - section.TStart) * j / 100.0;

                    PointF p = section.GetPoint(t);

                    points[j] = new PointF(
                        x + p.X,
                        warpY + p.Y);
                }

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(points);
                    g.FillPath(warpBrush, path);
                }

                // Offset by 1 because index 0 is reserved for the left end point
                weftPoints[i + 1] = new PointF(x, weftY);
            }

            // Extend the weft curve to the left and right edges of the fabric
            // (same extent as the top view).
            weftPoints[0] = new PointF(0f, weftPoints[1].Y);
            weftPoints[weftPoints.Length - 1] =
                new PointF(weave.FabricWidth, weftPoints[weftPoints.Length - 2].Y);

            if (weftPoints.Length >= 2)
            {
                g.DrawCurve(weftPen, weftPoints);
            }
        }
    }
}