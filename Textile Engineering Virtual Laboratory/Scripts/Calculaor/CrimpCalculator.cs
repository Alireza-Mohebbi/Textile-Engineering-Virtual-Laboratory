using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    class CrimpCalculator : AbstractCalculator
    {
        public override void CalculateWarpsCrimp(Weave weave)
        {
            List<PointF> warpsCoordinatesAtIntersections = new List<PointF>();
            List<PointF> weftsCoordinatesAtIntersections = new List<PointF>();
            bool isWarpOverWeft;

            // Define intersection points for each warp and weft
            for (int i = 0; i < weave.WarpCount; i++)
            {
                // Start point for this warp
                if (weave.WeftCount > 0)
                {
                    float startY = weave.IsWarpOverWeft[i, 0]
                        ? weave.YarnThickness
                        : 0;

                    warpsCoordinatesAtIntersections.Add(
                        new PointF(
                            0,
                            startY
                        )
                    );
                }

                for (int j = 0; j < weave.WeftCount; j++)
                {
                    float intersectionX =
                        (j * weave.YarnSpacing) + (weave.YarnSpacing / 2);

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

                    warpsCoordinatesAtIntersections.Add(
                        new PointF(
                            intersectionX,
                            warpIntersectionY
                        )
                    );

                    weftsCoordinatesAtIntersections.Add(
                        new PointF(
                            intersectionX,
                            weftIntersectionY
                        )
                    );
                }

                // End point for this warp
                if (weave.WeftCount > 0)
                {
                    int lastIndex = warpsCoordinatesAtIntersections.Count - 1;

                    warpsCoordinatesAtIntersections.Add(
                        new PointF(
                            warpsCoordinatesAtIntersections[lastIndex].X
                                + weave.YarnSpacing / 2,
                            warpsCoordinatesAtIntersections[lastIndex].Y
                        )
                    );
                }
            }

            // MessageBox logger
            string message = "Warp coordinates:\n";

            for (int i = 0; i < warpsCoordinatesAtIntersections.Count; i++)
            {
                message += $"Warp Point {i}: " +
                           $"X = {warpsCoordinatesAtIntersections[i].X}, " +
                           $"Y = {warpsCoordinatesAtIntersections[i].Y}\n";
            }

            message += "\nWeft coordinates:\n";

            for (int i = 0; i < weftsCoordinatesAtIntersections.Count; i++)
            {
                message += $"Weft Point {i}: " +
                           $"X = {weftsCoordinatesAtIntersections[i].X}, " +
                           $"Y = {weftsCoordinatesAtIntersections[i].Y}\n";
            }

            MessageBox.Show(message, "Crimp Calculator Logger");
        }
    }
}