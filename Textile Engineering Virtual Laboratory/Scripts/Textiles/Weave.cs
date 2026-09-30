using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextileEngineeringVirtualLaboratory.Textiles
{
    public class Weave
    {
        /// Weave physical properties ///
        public int NumberOfWarps { get; set; }
        public float WarpWidth { get; set; }
        public float WarpDiameter { get; set; }
        public float WarpSpacing { get; set; }
        public int NumberOfWefts { get; set; }
        public float WeftWidth { get; set; }
        public float WeftDiameter { get; set; }
        public float WeftSpacing { get; set; }
        public float YarnWidth { get; set; }        // (mm)
        public float YarnDiameter { get; set; }    // (mm)
        public float YarnSpacing { get; set; }      // (mm)
        public bool[,] IsWarpOverWeft { get; set; }
        public int RepeatX { get; set; }
        public int RepeatY { get; set; }
        public int NumberOfLayers { get { return 1; } }
        public float FabricWidth { get { return WarpSpacing * NumberOfWarps * RepeatX; } }    // (mm)
        public float FabricHeight { get { return WeftSpacing * NumberOfWefts * RepeatY; } }   // (mm)
        public float FabricThickness { get { return NumberOfLayers * (WarpDiameter + WeftDiameter); } }  // (mm)

        /// Weave mechanical properties ///
        public float YoungsModulusX { get; set; }       // (MPa)
        public float YoungsModulusY { get; set; }       // (MPa)
        public float FabricArialDensity { get; set; }   // (Kg/mm^2)

        /// Other general properties ///
        private const float gravitaionalAcceleration = 9810;    // (mm/s^2)

        /// Warps and wefts path points and lengths ///
        public PointF[,] WarpsPathPointsInUnitCell { get; private set; }
        public float[] WarpsStraightLengthsInUnitCell { get; private set; }
        public float[] WarpsCurvedLengthsInUnitCell { get; private set; }
        public float SumOfWarpsStraightLengthsInUnitCell { get; private set; }
        public float SumOfWarpsCurvedLengthsInUnitCell { get; private set; }
        public PointF[,] WeftsPathPointsInUnitCell { get; private set; }
        public float[] WeftsStraightLengthsInUnitCell { get; private set; }
        public float[] WeftsCurvedLengthsInUnitCell { get; private set; }
        public float SumOfWeftsStraightLengthsInUnitCell { get; private set; }
        public float SumOfWeftsCurvedLengthsInUnitCell { get; private set; }

        public Weave(int numberOfWarps, int numberOfWefts, float yarnWidth, float yarnThickness, float yarnSpacing, int repeatX, int repeatY)
        {
            NumberOfWarps = numberOfWarps;
            NumberOfWefts = numberOfWefts;

            YarnWidth = yarnWidth;
            YarnDiameter = yarnThickness;
            YarnSpacing = yarnSpacing;

            WarpWidth = yarnWidth;
            WarpDiameter = yarnThickness;
            WarpSpacing = yarnSpacing;

            WeftWidth = yarnWidth;
            WeftDiameter = yarnThickness;
            WeftSpacing = yarnSpacing;

            RepeatX = repeatX;
            RepeatY = repeatY;

            MakeInterlacementMatrix();
        }

        private void MakeInterlacementMatrix()
        {
            IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];

            for (int i = 0; i < NumberOfWarps; i++)
            {
                for (int j = 0; j < NumberOfWefts; j++)
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
            WarpsPathPointsInUnitCell = new PointF[NumberOfWarps, NumberOfWefts + 2];

            for (int i = 0; i < NumberOfWarps; i++)
            {
                // First path point
                float firstPointY = IsWarpOverWeft[i, 0] ? WeftDiameter / 2 : -WeftDiameter / 2;
                WarpsPathPointsInUnitCell[i, 0] = (new PointF(0, firstPointY));

                // Middle path points
                for (int j = 0; j < NumberOfWefts; j++)
                {
                    float warpXAtInterlacement = (j * WeftSpacing) + (WeftSpacing / 2);
                    float warpYAtInterlacement;

                    if (IsWarpOverWeft[i, j])
                    {
                        warpYAtInterlacement = WeftDiameter / 2;
                    }
                    else
                    {
                        warpYAtInterlacement = -WeftDiameter / 2;
                    }

                    WarpsPathPointsInUnitCell[i, j + 1] = (new PointF(warpXAtInterlacement, warpYAtInterlacement));
                }

                // Last path point
                int lastPointIndex = WarpsPathPointsInUnitCell.GetLength(1) - 1;
                WarpsPathPointsInUnitCell[i, lastPointIndex] = (new PointF(WarpsPathPointsInUnitCell[i, lastPointIndex - 1].X + WeftSpacing / 2, WarpsPathPointsInUnitCell[i, lastPointIndex - 1].Y));
            }
        }

        private void CalculateLengthsOfEachWarp()
        {
            SumOfWarpsStraightLengthsInUnitCell = 0;
            SumOfWarpsCurvedLengthsInUnitCell = 0;

            WarpsStraightLengthsInUnitCell = new float[NumberOfWarps];
            WarpsCurvedLengthsInUnitCell = new float[NumberOfWarps];

            for (int i = 0; i < NumberOfWarps; i++)
            {
                for (int j = 0; j < NumberOfWefts + 1; j++)
                {
                    float warpSegmentAngle = (float)Math.Atan(Math.Abs((WarpsPathPointsInUnitCell[i, j + 1].Y - WarpsPathPointsInUnitCell[i, j].Y) / (WarpsPathPointsInUnitCell[i, j + 1].X - WarpsPathPointsInUnitCell[i, j].X)));
                    float warpSegmentStraightLength = Math.Abs(WarpsPathPointsInUnitCell[i, j + 1].X - WarpsPathPointsInUnitCell[i, j].X);
                    float warpSegmentCurvedLength = (warpSegmentStraightLength * (1 / (float)Math.Cos(warpSegmentAngle))) + ((WarpDiameter + WeftDiameter) * (warpSegmentAngle - (float)Math.Tan(warpSegmentAngle)));

                    WarpsStraightLengthsInUnitCell[i] += warpSegmentStraightLength;
                    WarpsCurvedLengthsInUnitCell[i] += warpSegmentCurvedLength;

                    SumOfWarpsStraightLengthsInUnitCell += warpSegmentStraightLength;
                    SumOfWarpsCurvedLengthsInUnitCell += warpSegmentCurvedLength;
                }
            }
        }

        private void DefinePathPointsForEachWeft()
        {
            WeftsPathPointsInUnitCell = new PointF[NumberOfWefts, NumberOfWarps + 2];

            for (int i = 0; i < NumberOfWefts; i++)
            {
                // First path point
                float firstPointY = IsWarpOverWeft[0, i] ? -WarpDiameter / 2 : WarpDiameter / 2;
                WeftsPathPointsInUnitCell[i, 0] = (new PointF(0, firstPointY));

                // Middle path points
                for (int j = 0; j < NumberOfWarps; j++)
                {
                    float weftXAtInterlacement = (j * WarpSpacing) + (WarpSpacing / 2);
                    float weftYAtInterlacement;

                    if (IsWarpOverWeft[j, i])
                    {
                        weftYAtInterlacement = -WarpDiameter / 2;
                    }
                    else
                    {
                        weftYAtInterlacement = WarpDiameter / 2;
                    }

                    WeftsPathPointsInUnitCell[i, j + 1] = (new PointF(weftXAtInterlacement, weftYAtInterlacement));
                }

                // Last path point
                int lastPointIndex = WeftsPathPointsInUnitCell.GetLength(1) - 1;
                WeftsPathPointsInUnitCell[i, lastPointIndex] = (new PointF(WeftsPathPointsInUnitCell[i, lastPointIndex - 1].X + WarpSpacing / 2, WeftsPathPointsInUnitCell[i, lastPointIndex - 1].Y));
            }
        }

        private void CalculateLengthsOfEachWeft()
        {
            SumOfWeftsStraightLengthsInUnitCell = 0;
            SumOfWeftsCurvedLengthsInUnitCell = 0;

            WeftsStraightLengthsInUnitCell = new float[NumberOfWefts];
            WeftsCurvedLengthsInUnitCell = new float[NumberOfWefts];

            for (int i = 0; i < NumberOfWefts; i++)
            {
                for (int j = 0; j < NumberOfWarps + 1; j++)
                {
                    float weftSegmentAngle = (float)Math.Atan(Math.Abs((WeftsPathPointsInUnitCell[i, j + 1].Y - WeftsPathPointsInUnitCell[i, j].Y) / (WeftsPathPointsInUnitCell[i, j + 1].X - WeftsPathPointsInUnitCell[i, j].X)));
                    float weftSegmentStraightLength = Math.Abs(WeftsPathPointsInUnitCell[i, j + 1].X - WeftsPathPointsInUnitCell[i, j].X);
                    float weftSegmentCurvedLength = (weftSegmentStraightLength * (1 / (float)Math.Cos(weftSegmentAngle))) + ((WarpDiameter + WeftDiameter) * (weftSegmentAngle - (float)Math.Tan(weftSegmentAngle)));

                    WeftsStraightLengthsInUnitCell[i] += weftSegmentStraightLength;
                    WeftsCurvedLengthsInUnitCell[i] += weftSegmentCurvedLength;

                    SumOfWeftsStraightLengthsInUnitCell += weftSegmentStraightLength;
                    SumOfWeftsCurvedLengthsInUnitCell += weftSegmentCurvedLength;
                }
            }
        }
    }
}