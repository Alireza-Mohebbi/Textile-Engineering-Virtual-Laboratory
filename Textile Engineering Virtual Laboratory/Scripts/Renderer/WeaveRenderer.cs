using System.Drawing;
using System.Drawing.Drawing2D;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Renderer
{
    public class WeaveRenderer
    {
        private Weave weave;
        private Graphics weaveGraphics;

        public void Draw(Weave weave, Graphics g)
        {
            if (weave == null || g == null)
            {
                return;
            }

            this.weave = weave;
            weaveGraphics = g;

            DrawTopView();
            DrawCrossSection();
        }

        private void DrawTopView()
        {
            using (Pen warpPen = new Pen(Color.Red, weave.YarnWidth))
            using (Pen weftPen = new Pen(Color.Blue, weave.YarnWidth))
            {
                // Warp yarns
                for (int i = 0; i < weave.WarpCount; i++)
                {
                    float x = i * weave.YarnSpacing;
                    weaveGraphics.DrawLine(warpPen, x, 0, x, (weave.WeftCount - 1) * weave.YarnSpacing);
                }
                // Weft yarns
                for (int i = 0; i < weave.WeftCount; i++)
                {
                    float y = i * weave.YarnSpacing;
                    weaveGraphics.DrawLine( weftPen, 0, y, (weave.WarpCount - 1) * weave.YarnSpacing, y);
                }
            }

            // Size of the visible intersection gap
            float gap = weave.YarnWidth;

            using (Pen redPen = new Pen(Color.Red, weave.YarnWidth))
            using (Pen bluePen = new Pen(Color.Blue, weave.YarnWidth))
            {
                for (int x = 0; x < weave.WarpCount; x++)
                {
                    for (int y = 0; y < weave.WeftCount; y++)
                    {
                        float cx = x * weave.YarnSpacing;
                        float cy = y * weave.YarnSpacing;

                        if (weave.IsWarpOverWeft[x, y])
                        {
                            weaveGraphics.DrawLine(bluePen, cx - gap, cy, cx + gap, cy);
                            weaveGraphics.DrawLine(redPen, cx, cy - gap, cx, cy + gap);
                        }
                        else
                        {
                            weaveGraphics.DrawLine(redPen, cx, cy - gap, cx, cy + gap);
                            weaveGraphics.DrawLine(bluePen, cx - gap, cy, cx + gap, cy);
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

                    using (Brush warpBrush =
                           new SolidBrush(Color.Red))
                    {
                        weaveGraphics.FillEllipse(warpBrush, crossSectionX - weave.YarnWidth / 2f, warpY - weave.YarnThickness / 2f, weave.YarnWidth, weave.YarnThickness);
                    }
                }

                if (weftCurveControlPoints.Length > 1)
                {
                    weaveGraphics.DrawCurve( weftPen, weftCurveControlPoints);
                }
            }
        }
    }
}