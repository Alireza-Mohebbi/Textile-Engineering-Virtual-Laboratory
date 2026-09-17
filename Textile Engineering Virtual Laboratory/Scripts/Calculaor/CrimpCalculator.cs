using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    class CrimpCalculator : AbstractCalculator
    {
        private Weave weave;
        List<PointF> warpsPathPoints = new List<PointF>();
        List<PointF> weftsCrossSectionCenterPointsAtIntersections = new List<PointF>();
        bool isWarpOverWeft;

        public override void CalculateWarpsCrimp(Weave weave)
        {
            this.weave = weave;

            // Define path points for each warp, and cross section center points at intersections for each weft
            for (int i = 0; i < weave.WarpCount; i++)
            {
                // Start point for current warp
                if (weave.WeftCount > 0)
                {
                    float startY = weave.IsWarpOverWeft[i, 0] ? weave.YarnThickness : 0;
                    warpsPathPoints.Add(new PointF(0, startY));
                }

                // Main points for current warp
                for (int j = 0; j < weave.WeftCount; j++)
                {
                    float intersectionX = (j * weave.YarnSpacing) + (weave.YarnSpacing / 2);
                    float warpIntersectionY;
                    float weftIntersectionY;
                    isWarpOverWeft = weave.IsWarpOverWeft[i, j];

                    if (isWarpOverWeft)
                    {
                        warpIntersectionY = weave.YarnThickness;
                        weftIntersectionY = 0;
                    }
                    else
                    {
                        warpIntersectionY = 0;
                        weftIntersectionY = weave.YarnThickness;
                    }

                    warpsPathPoints.Add(new PointF(intersectionX, warpIntersectionY));
                    weftsCrossSectionCenterPointsAtIntersections.Add(new PointF(intersectionX, weftIntersectionY));
                }

                // End point for current warp
                if (weave.WeftCount > 0)
                {
                    int lastIndex = warpsPathPoints.Count - 1;
                    warpsPathPoints.Add(new PointF(warpsPathPoints[lastIndex].X + weave.YarnSpacing / 2, warpsPathPoints[lastIndex].Y));
                }
            }


            //////////////////////////////////////////////////////
            // Calculate warps' overlap arc lengths at intersections
            CalculateWarpsOverlapArcLengthsAtIntersections();


            //////////////////////////////////////////////////////
            // Log path points of each warp, and cross section center points at intersections of each weft
            string message = "Warp coordinates:\n";

            for (int i = 0; i < warpsPathPoints.Count; i++)
            {
                message += $"Warp Point {i}: " + $"X = {warpsPathPoints[i].X}, " + $"Y = {warpsPathPoints[i].Y}\n";
            }

            message += "\nWeft coordinates:\n";

            for (int i = 0; i < weftsCrossSectionCenterPointsAtIntersections.Count; i++)
            {
                message += $"Weft Point {i}: " + $"X = {weftsCrossSectionCenterPointsAtIntersections[i].X}, " + $"Y = {weftsCrossSectionCenterPointsAtIntersections[i].Y}\n";
            }

            MessageBox.Show(message, "Warp and weft path points");
        }

        private void CalculateWarpsOverlapArcLengthsAtIntersections()
        {
            float[,] warpSegmentAngle = new float[weave.WarpCount, weave.WeftCount + 1];
            float[,] warpSegmentLength = new float[weave.WarpCount, weave.WeftCount + 1];
            int k = 0;

            for (int i = 0; i < weave.WarpCount; i++)
            {
                for (int j = 0; j < weave.WeftCount + 1; j++, k++)
                {
                    warpSegmentAngle[i, j] = (float)Math.Atan(Math.Abs((warpsPathPoints[k + 1].Y - warpsPathPoints[k].Y) / (warpsPathPoints[k + 1].X - warpsPathPoints[k].X)));
                    warpSegmentLength[i, j] = (float)Math.Sqrt(Math.Pow(warpsPathPoints[k + 1].X - warpsPathPoints[k].X, 2) + Math.Pow(warpsPathPoints[k + 1].Y - warpsPathPoints[k].Y, 2));
                }
                k++;
            }

            // Log
            string message = "";

            for (int i = 0; i < warpSegmentAngle.GetLength(0); i++)
            {
                message += $"Warp {i}:\n";

                for (int j = 0; j < warpSegmentAngle.GetLength(1); j++)
                {
                    message += $"  Segment {j}: " +
                               $"Angle = {warpSegmentAngle[i, j]:F3}, " +
                               $"Length = {warpSegmentLength[i, j]:F3}\n";
                }

                message += "\n";
            }

            MessageBox.Show(message, "Angle and lengths of warp segments");
        }
    }
}