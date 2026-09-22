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
                for (int i = 0; i < weave.WarpCount; i++)
                {
                    float x = i * weave.WarpSpacing;
                    g.DrawLine(warpPen, x, 0, x, (weave.WeftCount - 1) * weave.WarpSpacing);
                }

                // Draw wefts
                for (int i = 0; i < weave.WeftCount; i++)
                {
                    float y = i * weave.WeftSpacing;
                    g.DrawLine(weftPen, 0, y, (weave.WarpCount - 1) * weave.WeftSpacing, y);
                }

                // Draw interlacements
                for (int x = 0; x < weave.WarpCount; x++)
                {
                    for (int y = 0; y < weave.WeftCount; y++)
                    {
                        float cx = x * weave.YarnSpacing;
                        float cy = y * weave.YarnSpacing;

                        if (weave.IsWarpOverWeft[x, y])
                        {
                            g.DrawLine(weftPen, cx - weave.WeftWidth, cy, cx + weave.WeftWidth, cy);
                            g.DrawLine(warpPen, cx, cy - weave.WarpWidth, cx, cy + weave.WarpWidth);
                        }
                        else
                        {
                            g.DrawLine(warpPen, cx, cy - weave.WarpWidth, cx, cy + weave.WarpWidth);
                            g.DrawLine(weftPen, cx - weave.WeftWidth, cy, cx + weave.WeftWidth, cy);
                        }
                    }
                }
            }
        }

        private void DrawCrossSection()
        {
            int bottomRowWeftIndex = weave.WeftCount - 1;

            using (Pen weftPen = new Pen(Color.Blue, weave.WeftThickness))
            {
                weftPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Flat);
                PointF[] weftCurveControlPoints = new PointF[weave.WarpCount];

                for (int i = 0; i < weave.WarpCount; i++)
                {
                    float warpCrossSectionX = i * weave.WarpSpacing;
                    bool isWarpOverWeft = weave.IsWarpOverWeft[i, bottomRowWeftIndex];
                    float warpY;
                    float weftY;

                    if (isWarpOverWeft)
                    {
                        warpY = (weave.FabricHeight / weave.RepeatY) - (weave.WeftThickness / 2);
                        weftY = (weave.FabricHeight / weave.RepeatY) + (weave.WeftThickness / 2);
                    }
                    else
                    {
                        warpY = (weave.FabricHeight / weave.RepeatY) + weave.WeftThickness / 2f;
                        weftY = (weave.FabricHeight / weave.RepeatY) - weave.WeftThickness / 2f;
                    }

                    weftCurveControlPoints[i] = new PointF(warpCrossSectionX, weftY);

                    using (Brush warpBrush = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(warpBrush, warpCrossSectionX - weave.YarnWidth / 2f, warpY - weave.YarnThickness / 2f, weave.YarnWidth, weave.YarnThickness);
                    }
                }

                if (weftCurveControlPoints.Length > 1)
                {
                    g.DrawCurve(weftPen, weftCurveControlPoints);
                }
            }
        }
    }
}
