using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Renderer
{
    public class WeaveRenderer
    {
        private Weave weave;
        private Graphics g;

        public void Draw(Weave weave, Graphics g)
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
            using (Pen warpPen = new Pen(Color.Red, weave.WarpWidth))
            using (Pen weftPen = new Pen(Color.Blue, weave.WeftWidth))
            {
                // Draw warps
                for (int i = 0; i < weave.NumberOfWarps; i++)
                {
                    g.DrawLine(warpPen, i * weave.WarpSpacing + weave.WarpSpacing / 2, 0, i * weave.WarpSpacing + weave.WarpSpacing / 2, weave.FabricHeight / weave.RepeatY);
                }

                // Draw wefts
                for (int i = 0; i < weave.NumberOfWefts; i++)
                {
                    g.DrawLine(weftPen, 0, i * weave.WeftSpacing + weave.WeftSpacing / 2, weave.FabricWidth / weave.RepeatX, i * weave.WeftSpacing + weave.WeftSpacing / 2);
                }

                // Draw interlacements
                for (int i = 0; i < weave.NumberOfWarps; i++)
                {
                    for (int j = 0; j < weave.NumberOfWefts; j++)
                    {
                        float interlacementCenterX = i * weave.WarpSpacing + weave.WarpSpacing / 2f;
                        float interlacementCenterY = j * weave.WeftSpacing + weave.WeftSpacing / 2f;

                        float interlacementBoundingBoxLeft = interlacementCenterX - weave.WarpWidth / 2f;
                        float interlacementBoundingBoxTop = interlacementCenterY - weave.WarpWidth / 2f;

                        RectangleF warpInterlacementBoundingBox = new RectangleF(interlacementBoundingBoxLeft, interlacementBoundingBoxTop, weave.WarpWidth, weave.WarpWidth);
                        RectangleF weftInterlacementBoundingBox = new RectangleF(interlacementBoundingBoxLeft, interlacementBoundingBoxTop, weave.WeftWidth, weave.WeftWidth);

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
            int bottomRowWeftIndex = weave.NumberOfWefts - 1;

            using (Pen weftPen = new Pen(Color.Blue, weave.WeftDiameter))
            {
                PointF[] weftCurveControlPoints = new PointF[weave.NumberOfWarps + 2];

                for (int i = 0; i < weave.NumberOfWarps; i++)
                {
                    float warpCrossSectionX = i * weave.WarpSpacing + weave.WarpSpacing / 2f;
                    bool isWarpOverWeft = weave.IsWarpOverWeft[i, bottomRowWeftIndex];
                    float warpY;
                    float weftY;

                    if (isWarpOverWeft)
                    {
                        warpY = (weave.FabricHeight / weave.RepeatY) - (weave.WeftDiameter / 2f) + weave.FabricThickness / 2;
                        weftY = (weave.FabricHeight / weave.RepeatY) + (weave.WarpDiameter / 2f) + weave.FabricThickness / 2;
                    }
                    else
                    {
                        warpY = (weave.FabricHeight / weave.RepeatY) + (weave.WeftDiameter / 2f) + weave.FabricThickness / 2;
                        weftY = (weave.FabricHeight / weave.RepeatY) - (weave.WarpDiameter / 2f) + weave.FabricThickness / 2;
                    }

                    weftCurveControlPoints[i + 1] = new PointF(warpCrossSectionX, weftY);

                    using (Brush warpBrush = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(warpBrush, warpCrossSectionX - weave.WarpWidth / 2f, warpY - weave.WarpDiameter / 2f, weave.WarpWidth, weave.WarpDiameter);
                    }
                }

                // Extend the curve horizontally from the first interlacement
                weftCurveControlPoints[0] = new PointF(0, weftCurveControlPoints[1].Y);

                // Extend the curve horizontally after the last interlacement
                float lastInterlacementX = weftCurveControlPoints[weave.NumberOfWarps].X;
                weftCurveControlPoints[weave.NumberOfWarps + 1] = new PointF(lastInterlacementX + weave.WarpSpacing / 2f, weftCurveControlPoints[weave.NumberOfWarps].Y);
                g.DrawCurve(weftPen, weftCurveControlPoints);
            }
        }
    }
}
