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
            using (Pen warpPen = new Pen(Color.Red, weave.YarnWidth))
            using (Pen weftPen = new Pen(Color.Blue, weave.YarnWidth))
            {
                // Draw weave
                for (int i = 0; i < weave.WarpCount; i++)
                {
                    float x = i * weave.YarnSpacing;
                    g.DrawLine(warpPen, x, 0, x, (weave.WeftCount - 1) * weave.YarnSpacing);
                }
                for (int i = 0; i < weave.WeftCount; i++)
                {
                    float y = i * weave.YarnSpacing;
                    g.DrawLine( weftPen, 0, y, (weave.WarpCount - 1) * weave.YarnSpacing, y);
                }

                // Draw warp-weft intersections
                float gap = weave.YarnWidth;

                for (int x = 0; x < weave.WarpCount; x++)
                {
                    for (int y = 0; y < weave.WeftCount; y++)
                    {
                        float cx = x * weave.YarnSpacing;
                        float cy = y * weave.YarnSpacing;

                        if (weave.IsWarpOverWeft[x, y])
                        {
                            g.DrawLine(weftPen, cx - gap, cy, cx + gap, cy);
                            g.DrawLine(warpPen, cx, cy - gap, cx, cy + gap);
                        }
                        else
                        {
                            g.DrawLine(warpPen, cx, cy - gap, cx, cy + gap);
                            g.DrawLine(weftPen, cx - gap, cy, cx + gap, cy);
                        }
                    }
                }
            }
        }

        private void DrawCrossSection()
        {
            if (weave.WarpCount == 0 || weave.WeftCount == 0)
            {
                return;
            }

            float crossSectionY = weave.WeftCount * (weave.YarnWidth + weave.YarnSpacing) - weave.YarnSpacing;
            int bottomRowWeft = weave.WeftCount - 1;

            using (Pen weftPen = new Pen(Color.Blue, weave.YarnThickness))
            {
                weftPen.SetLineCap( LineCap.Round, LineCap.Round, DashCap.Flat);
                PointF[] weftCurveControlPoints = new PointF[weave.WarpCount];

                for (int i = 0; i < weave.WarpCount; i++)
                {
                    float crossSectionX = i * weave.YarnSpacing;
                    bool isWarpOverWeft = weave.IsWarpOverWeft[i, bottomRowWeft];
                    float warpY;
                    float weftY;

                    if (isWarpOverWeft)
                    {
                        warpY = crossSectionY - weave.YarnThickness / 2f;
                        weftY = crossSectionY + weave.YarnThickness / 2f;
                    }
                    else
                    {
                        warpY = crossSectionY + weave.YarnThickness / 2f;
                        weftY = crossSectionY - weave.YarnThickness / 2f;
                    }

                    weftCurveControlPoints[i] = new PointF(crossSectionX, weftY);

                    using (Brush warpBrush = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(warpBrush, crossSectionX - weave.YarnWidth / 2f, warpY - weave.YarnThickness / 2f, weave.YarnWidth, weave.YarnThickness);
                    }
                }

                if (weftCurveControlPoints.Length > 1)
                {
                    g.DrawCurve( weftPen, weftCurveControlPoints);
                }
            }
        }
    }
}