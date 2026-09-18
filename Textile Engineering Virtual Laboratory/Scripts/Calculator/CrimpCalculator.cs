using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    class CrimpCalculator : AbstractCalculator
    {
        List<PointF> warpsPathPoints = new List<PointF>();
        List<PointF> weftsCrossSectionCenterPointsAtIntersections = new List<PointF>();

public override void CalculateCrimp(Weave weave, string direction)
        {
            bool isWarp;

            if (direction.Equals("warp", StringComparison.OrdinalIgnoreCase))
            {
                isWarp = true;
            }
            else if (direction.Equals("weft", StringComparison.OrdinalIgnoreCase))
            {
                isWarp = false;
            }
            else
            {
                throw new ArgumentException(
                    "Direction must be either 'warp' or 'weft'.",
                    nameof(direction));
            }

            int yarnCount = isWarp ? weave.WarpCount : weave.WeftCount;
            int crossingCount = isWarp ? weave.WeftCount : weave.WarpCount;

            if (yarnCount == 0 || crossingCount == 0)
            {
                MessageBox.Show("There are no yarns available for crimp calculation.");
                return;
            }

            float[] crimpOfEachYarn = new float[yarnCount];

            float totalProjectedLength = 0;
            float totalStraightenedLength = 0;

            ////////////////////////////////////////////////////////////
            // Calculate each yarn
            ////////////////////////////////////////////////////////////

            for (int i = 0; i < yarnCount; i++)
            {
                List<PointF> pathPoints = new List<PointF>();

                ////////////////////////////////////////////////////////////
                // Start point
                ////////////////////////////////////////////////////////////

                bool warpOverWeftAtStart;

                if (isWarp)
                {
                    // Current yarn = warp i
                    // Current crossing = weft 0
                    warpOverWeftAtStart =
                        weave.IsWarpOverWeft[i, 0];
                }
                else
                {
                    // Current yarn = weft i
                    // Current crossing = warp 0
                    warpOverWeftAtStart =
                        weave.IsWarpOverWeft[0, i];
                }

                // For warp:
                //   warp over -> high
                //   warp under -> low
                //
                // For weft:
                //   warp over -> weft under -> low
                //   warp under -> weft over -> high

                float startY;

                if (isWarp)
                {
                    startY = warpOverWeftAtStart
                        ? weave.YarnThickness
                        : 0;
                }
                else
                {
                    startY = warpOverWeftAtStart
                        ? 0
                        : weave.YarnThickness;
                }

                pathPoints.Add(new PointF(0, startY));

                ////////////////////////////////////////////////////////////
                // Intersection points
                ////////////////////////////////////////////////////////////

                for (int j = 0; j < crossingCount; j++)
                {
                    bool warpOverWeft;

                    if (isWarp)
                    {
                        // Current warp i crossing weft j
                        warpOverWeft =
                            weave.IsWarpOverWeft[i, j];
                    }
                    else
                    {
                        // Current weft i crossing warp j
                        warpOverWeft =
                            weave.IsWarpOverWeft[j, i];
                    }

                    float yarnY;

                    if (isWarp)
                    {
                        // Warp follows the matrix value directly
                        yarnY = warpOverWeft
                            ? weave.YarnThickness
                            : 0;
                    }
                    else
                    {
                        // Weft is opposite to the matrix value
                        yarnY = warpOverWeft
                            ? 0
                            : weave.YarnThickness;
                    }

                    float intersectionX =
                        j * weave.YarnSpacing
                        + weave.YarnSpacing / 2f;

                    pathPoints.Add(
                        new PointF(intersectionX, yarnY));
                }

                ////////////////////////////////////////////////////////////
                // End point
                ////////////////////////////////////////////////////////////

                int lastIndex = pathPoints.Count - 1;

                pathPoints.Add(
                    new PointF(
                        pathPoints[lastIndex].X
                            + weave.YarnSpacing / 2f,
                        pathPoints[lastIndex].Y));

                ////////////////////////////////////////////////////////////
                // Calculate lengths
                ////////////////////////////////////////////////////////////

                float projectedLength = 0;
                float straightenedLength = 0;

                for (int j = 0; j < pathPoints.Count - 1; j++)
                {
                    float dx =
                        pathPoints[j + 1].X
                        - pathPoints[j].X;

                    float dy =
                        pathPoints[j + 1].Y
                        - pathPoints[j].Y;

                    float segmentLength =
                        (float)Math.Sqrt(
                            dx * dx + dy * dy);

                    float angle = 0;

                    if (Math.Abs(dx) > 0.000001f)
                    {
                        angle =
                            (float)Math.Atan(
                                Math.Abs(dy / dx));
                    }

                    float straightenedSegmentLength =
                        segmentLength
                        / (float)Math.Cos(angle)
                        +
                        (
                            2f * weave.YarnThickness
                            *
                            (
                                angle
                                - (float)Math.Tan(angle)
                            )
                        );

                    projectedLength += segmentLength;
                    straightenedLength +=
                        straightenedSegmentLength;
                }

                ////////////////////////////////////////////////////////////
                // Crimp of individual yarn
                ////////////////////////////////////////////////////////////

                if (projectedLength > 0)
                {
                    crimpOfEachYarn[i] =
                        (
                            (straightenedLength - projectedLength)
                            / projectedLength
                        ) * 100f;
                }

                ////////////////////////////////////////////////////////////
                // Fabric totals
                ////////////////////////////////////////////////////////////

                totalProjectedLength += projectedLength;
                totalStraightenedLength += straightenedLength;
            }

            ////////////////////////////////////////////////////////////
            // Fabric crimp
            ////////////////////////////////////////////////////////////

            float fabricCrimp = 0;

            if (totalProjectedLength > 0)
            {
                fabricCrimp =
                    (
                        (totalStraightenedLength
                         - totalProjectedLength)
                        / totalProjectedLength
                    ) * 100f;
            }

            ////////////////////////////////////////////////////////////
            // Display
            ////////////////////////////////////////////////////////////

            string message = "";

            for (int i = 0; i < yarnCount; i++)
            {
                message +=
                    $"{direction.ToUpper()} {i + 1} crimp: " +
                    $"{crimpOfEachYarn[i]:F2}%\n";
            }

            message +=
                $"\nFabric total crimp in {direction.ToLower()} direction = " +
                $"{fabricCrimp:F2}%";

            MessageBox.Show(message);
        }
    }
}