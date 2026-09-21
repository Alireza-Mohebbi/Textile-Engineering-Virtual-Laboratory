using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextileEngineeringVirtualLaboratory.Textiles
{
    public class Weave
    {
        /// Weave physical properties ///
        public int WarpCount { get; set; }
        public float WarpWidth { get; set; }
        public float WarpThickness { get; set; }
        public float WarpSpacing { get; set; }
        public int WeftCount { get; set; }
        public float WeftWidth { get; set; }
        public float WeftThickness { get; set; }
        public float WeftSpacing { get; set; }
        public float YarnWidth { get; set; }        // (mm)
        public float YarnThickness { get; set; }    // (mm)
        public float YarnSpacing { get; set; }      // (mm)
        public int LayerCount { get { return 1; } }
        public bool[,] IsWarpOverWeft { get; set; }
        public int RepeatX { get; set; }
        public int RepeatY { get; set; }
        public float FabricWidth { get { return YarnSpacing * WarpCount * RepeatX; } }    // (mm)
        public float FabricHeight { get { return YarnSpacing * WeftCount * RepeatY; } }   // (mm)
        public float FabricThickness { get { return LayerCount * (WarpThickness + WeftThickness); } }  // (mm)

        /// Weave mechanical properties ///
        public float YoungsModulusX { get; set; }       // (MPa)
        public float YoungsModulusY { get; set; }       // (MPa)
        public float FabricArialDensity { get; set; }   // (Kg/mm^2)

        /// Other general properties ///
        private const float gravitaionalAcceleration = 9810;    // (mm/s^2)

        /// Warps and wefts path points and lengths ///
        public PointF[,] WarpsPathPoints { get; set; }
        public float[] WarpsStraightLengths { get; set; }
        public float[] WarpsCurvedLengths { get; set; }
        public float SumOfWarpsStraightLengths { get; set; }
        public float SumOfWarpsCurvedLengths { get; set; }
        public PointF[,] WeftsPathPoints { get; set; }
        public float[] WeftsStraightLengths { get; set; }
        public float[] WeftsCurvedLengths { get; set; }
        public float SumOfWeftsStraightLengths { get; set; }
        public float SumOfWeftsCurvedLengths { get; set; }

        public Weave(int warpCount, int weftCount, float yarnWidth, float yarnThickness, float yarnSpacing, int repeatX, int repeatY)
        {
            WarpCount = warpCount;
            WeftCount = weftCount;

            YarnWidth = yarnWidth;
            YarnThickness = yarnThickness;
            YarnSpacing = yarnSpacing;

            WarpWidth = yarnWidth;
            WarpThickness = yarnThickness;
            WarpSpacing = yarnSpacing;

            WeftWidth = yarnWidth;
            WeftThickness = yarnThickness;
            WeftSpacing = yarnSpacing;

            RepeatX = repeatX;
            RepeatY = repeatY;

            MakeInterlacementMatrix();
        }

        private void MakeInterlacementMatrix()
        {
            IsWarpOverWeft = new bool[WarpCount, WeftCount];

            for (int i = 0; i < WarpCount; i++)
            {
                for (int j = 0; j < WeftCount; j++)
                {
                    IsWarpOverWeft[i, j] = (i + j) % 2 == 0;
                }
            }
        }

        public void CalculateYarnsPathPointsAndLengths()
        {
            DefinePathPointsForEachWarp();
            CalculateLengthsOfEachWarp();

            DefinePathPointsForEachWeft();
            CalculateLengthsOfEachWeft();
        }

        private void DefinePathPointsForEachWarp()
        {
            WarpsPathPoints = new PointF[WarpCount, WeftCount + 2];

            for (int i = 0; i < WarpCount; i++)
            {
                // First path point
                float firstPointY = IsWarpOverWeft[i, 0] ? WeftThickness / 2 : -WeftThickness / 2;
                WarpsPathPoints[i, 0] = (new PointF(0, firstPointY));

                // Middle path points
                for (int j = 0; j < WeftCount; j++)
                {
                    float warpXAtInterlacement = (j * WeftSpacing) + (WeftSpacing / 2);
                    float warpYAtInterlacement;

                    if (IsWarpOverWeft[i, j])
                    {
                        warpYAtInterlacement = WeftThickness / 2;
                    }
                    else
                    {
                        warpYAtInterlacement = -WeftThickness / 2;
                    }

                    WarpsPathPoints[i, j + 1] = (new PointF(warpXAtInterlacement, warpYAtInterlacement));
                }

                // Last path point
                int lastPointIndex = WarpsPathPoints.GetLength(1) - 1;
                WarpsPathPoints[i, lastPointIndex] = (new PointF(WarpsPathPoints[i, lastPointIndex - 1].X + WeftSpacing / 2, WarpsPathPoints[i, lastPointIndex - 1].Y));
            }
        }

        private void CalculateLengthsOfEachWarp()
        {
            SumOfWarpsStraightLengths = 0;
            SumOfWarpsCurvedLengths = 0;

            WarpsStraightLengths = new float[WarpCount];
            WarpsCurvedLengths = new float[WarpCount];

            for (int i = 0; i < WarpCount; i++)
            {
                for (int j = 0; j < WeftCount + 1; j++)
                {
                    float warpSegmentAngle = (float)Math.Atan(Math.Abs((WarpsPathPoints[i, j + 1].Y - WarpsPathPoints[i, j].Y) / (WarpsPathPoints[i, j + 1].X - WarpsPathPoints[i, j].X)));
                    float warpSegmentStraightLength = Math.Abs(WarpsPathPoints[i, j + 1].X - WarpsPathPoints[i, j].X);
                    float warpSegmentCurvedLength = (warpSegmentStraightLength * (1 / (float)Math.Cos(warpSegmentAngle))) + ((WarpThickness + WeftThickness) * (warpSegmentAngle - (float)Math.Tan(warpSegmentAngle)));

                    WarpsStraightLengths[i] += warpSegmentStraightLength;
                    WarpsCurvedLengths[i] += warpSegmentCurvedLength;

                    SumOfWarpsStraightLengths += warpSegmentStraightLength;
                    SumOfWarpsCurvedLengths += warpSegmentCurvedLength;
                }
            }
        }

        private void DefinePathPointsForEachWeft()
        {
            WeftsPathPoints = new PointF[WeftCount, WarpCount + 2];

            for (int i = 0; i < WeftCount; i++)
            {
                // First path point
                float firstPointY = IsWarpOverWeft[0, i] ? -WarpThickness / 2 : WarpThickness / 2;
                WeftsPathPoints[i, 0] = (new PointF(0, firstPointY));

                // Middle path points
                for (int j = 0; j < WarpCount; j++)
                {
                    float weftXAtInterlacement = (j * WarpSpacing) + (WarpSpacing / 2);
                    float weftYAtInterlacement;

                    if (IsWarpOverWeft[j, i])
                    {
                        weftYAtInterlacement = -WarpThickness / 2;
                    }
                    else
                    {
                        weftYAtInterlacement = WarpThickness / 2;
                    }

                    WeftsPathPoints[i, j + 1] = (new PointF(weftXAtInterlacement, weftYAtInterlacement));
                }

                // Last path point
                int lastPointIndex = WeftsPathPoints.GetLength(1) - 1;
                WeftsPathPoints[i, lastPointIndex] = (new PointF(WeftsPathPoints[i, lastPointIndex - 1].X + WarpSpacing / 2, WeftsPathPoints[i, lastPointIndex - 1].Y));
            }
        }

        private void CalculateLengthsOfEachWeft()
        {
            SumOfWeftsStraightLengths = 0;
            SumOfWeftsCurvedLengths = 0;

            WeftsStraightLengths = new float[WeftCount];
            WeftsCurvedLengths = new float[WeftCount];

            for (int i = 0; i < WeftCount; i++)
            {
                for (int j = 0; j < WarpCount + 1; j++)
                {
                    float weftSegmentAngle = (float)Math.Atan(Math.Abs((WeftsPathPoints[i, j + 1].Y - WeftsPathPoints[i, j].Y) / (WeftsPathPoints[i, j + 1].X - WeftsPathPoints[i, j].X)));
                    float weftSegmentStraightLength = Math.Abs(WeftsPathPoints[i, j + 1].X - WeftsPathPoints[i, j].X);
                    float weftSegmentCurvedLength = (weftSegmentStraightLength * (1 / (float)Math.Cos(weftSegmentAngle))) + ((WarpThickness + WeftThickness) * (weftSegmentAngle - (float)Math.Tan(weftSegmentAngle)));

                    WeftsStraightLengths[i] += weftSegmentStraightLength;
                    WeftsCurvedLengths[i] += weftSegmentCurvedLength;

                    SumOfWeftsStraightLengths += weftSegmentStraightLength;
                    SumOfWeftsCurvedLengths += weftSegmentCurvedLength;
                }
            }
        }
    }
}