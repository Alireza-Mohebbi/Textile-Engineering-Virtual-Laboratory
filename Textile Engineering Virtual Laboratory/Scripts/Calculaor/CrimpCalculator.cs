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

            CalculateCrimp();


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

        private void CalculateCrimp()
        {
            float sumOfWarpsProjectedLengths = 0;      // The short, visible length
            float sumOfWarpsStraightenedLengths = 0;   // The full length including interlacement curves
            float[] crimpOfEachWarp = new float[weave.WarpCount];
            float fabricCrimp = 0;
            int k = 0;

            for (int i = 0; i < weave.WarpCount; i++)
            {
                // Accumulate lengths for this individual warp
                float warpProjectedLength = 0;
                float warpStraightenedLength = 0;

                for (int j = 0; j < weave.WeftCount + 1; j++, k++)
                {
                    float warpSegmentAngle = (float)Math.Atan(Math.Abs((warpsPathPoints[k + 1].Y - warpsPathPoints[k].Y) / (warpsPathPoints[k + 1].X - warpsPathPoints[k].X)));
                    float warpSegmentProjectedLength = (float)Math.Sqrt(Math.Pow(warpsPathPoints[k + 1].X - warpsPathPoints[k].X, 2) + Math.Pow(warpsPathPoints[k + 1].Y - warpsPathPoints[k].Y, 2));
                    float warpSegmentStraightenedLength = (warpSegmentProjectedLength * (1 / (float)Math.Cos(warpSegmentAngle))) + ((2 * weave.YarnThickness) * (warpSegmentAngle - (float)Math.Tan(warpSegmentAngle)));

                    // Add this segment to the current warp
                    warpProjectedLength += warpSegmentProjectedLength;
                    warpStraightenedLength += warpSegmentStraightenedLength;

                    // Add this segment to the whole fabric
                    sumOfWarpsProjectedLengths += warpSegmentProjectedLength;
                    sumOfWarpsStraightenedLengths += warpSegmentStraightenedLength;
                }

                // Calculate crimp for this warp AFTER all its segments
                crimpOfEachWarp[i] = ((warpStraightenedLength - warpProjectedLength) / warpProjectedLength) * 100;
                k++;
            }

            fabricCrimp = ((sumOfWarpsStraightenedLengths - sumOfWarpsProjectedLengths) / (sumOfWarpsProjectedLengths)) * 100;

            /////////////////////
            // Print crimp values
            string messageNew = "";
            for (int i = 0; i < weave.WarpCount; i++)
            {
                messageNew += ("Warp " + (i + 1) + " crimp: " + crimpOfEachWarp[i]) + "%" + "\n";
            }
            MessageBox.Show(messageNew + "\nFabric total crimp in warp direction = " + fabricCrimp.ToString() + "%");
        }
    }
}