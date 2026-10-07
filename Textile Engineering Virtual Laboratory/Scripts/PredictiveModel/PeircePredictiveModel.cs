using System;
using System.Drawing;
using TextileEngineeringVirtualLaboratory.PredictiveModel;
using TextileEngineeringVirtualLaboratory.Textiles;

class PeircePredictiveModel : IPredictiveModel
{
    private Weave weave;

    public Weave CalculateTheGetWeaveParameters(Weave weave)
    {
        this.weave = weave;

        CalculateYarnDiameter();
        CalculateYarnSpacing();
        CalculatePathPointsAndLengthsOfYarns();
        CalculateCrimp();
        CalculatePorosity();

        return this.weave;
    }

    private void CalculateYarnDiameter()
    {
        weave.WarpDiameter = 25.4f * (1 / (28 * (float)Math.Sqrt(weave.WarpCount)));    // The 25.4X multiplication is to convert diameter unit from 'inch' to 'mm'
        weave.WeftDiameter = 25.4f * (1 / (28 * (float)Math.Sqrt(weave.WeftCount)));    // The 25.4X multiplication is to convert diameter unit from 'inch' to 'mm'
    }

    private void CalculateYarnSpacing()
    {

        weave.WarpSpacing = 1 / weave.WarpCompactness * 10; //The X10 multiplication is to convert cm to mm
        weave.WeftSpacing = 1 / weave.WeftCompactness * 10; // The X10 multiplication is to convert cm to mm

    }

    private void CalculatePathPointsAndLengthsOfYarns()
    {
        DefinePathPointsForEachWarp();
        CalculateLengthsOfEachWarp();

        DefinePathPointsForEachWeft();
        CalculateLengthsOfEachWeft();
    }

    private void DefinePathPointsForEachWarp()
    {
        weave.WarpsPathPointsInUnitCell = new PointF[weave.NumberOfWarps, weave.NumberOfWefts + 2];

        for (int i = 0; i < weave.NumberOfWarps; i++)
        {
            // First path point
            float firstPointY = weave.IsWarpOverWeft[i, 0] ? weave.WeftDiameter / 2 : -weave.WeftDiameter / 2;
            weave.WarpsPathPointsInUnitCell[i, 0] = (new PointF(0, firstPointY));

            // Middle path points
            for (int j = 0; j < weave.NumberOfWefts; j++)
            {
                float warpXAtInterlacement = (j * weave.WeftSpacing) + (weave.WeftSpacing / 2);
                float warpYAtInterlacement;

                if (weave.IsWarpOverWeft[i, j])
                {
                    warpYAtInterlacement = weave.WeftDiameter / 2;
                }
                else
                {
                    warpYAtInterlacement = -weave.WeftDiameter / 2;
                }

                weave.WarpsPathPointsInUnitCell[i, j + 1] = (new PointF(warpXAtInterlacement, warpYAtInterlacement));
            }

            // Last path point
            int lastPointIndex = weave.WarpsPathPointsInUnitCell.GetLength(1) - 1;
            weave.WarpsPathPointsInUnitCell[i, lastPointIndex] = (new PointF(weave.WarpsPathPointsInUnitCell[i, lastPointIndex - 1].X + weave.WeftSpacing / 2, weave.WarpsPathPointsInUnitCell[i, lastPointIndex - 1].Y));
        }
    }

    private void CalculateLengthsOfEachWarp()
    {
        weave.SumOfWarpsStraightLengthsInUnitCell = 0;
        weave.SumOfWarpsCurvedLengthsInUnitCell = 0;

        weave.WarpsStraightLengthsInUnitCell = new float[weave.NumberOfWarps];
        weave.WarpsCurvedLengthsInUnitCell = new float[weave.NumberOfWarps];

        for (int i = 0; i < weave.NumberOfWarps; i++)
        {
            for (int j = 0; j < weave.NumberOfWefts + 1; j++)
            {
                float warpSegmentAngle = (float)Math.Atan(Math.Abs((weave.WarpsPathPointsInUnitCell[i, j + 1].Y - weave.WarpsPathPointsInUnitCell[i, j].Y) / (weave.WarpsPathPointsInUnitCell[i, j + 1].X - weave.WarpsPathPointsInUnitCell[i, j].X)));
                float warpSegmentStraightLength = Math.Abs(weave.WarpsPathPointsInUnitCell[i, j + 1].X - weave.WarpsPathPointsInUnitCell[i, j].X);
                float warpSegmentCurvedLength = (warpSegmentStraightLength * (1 / (float)Math.Cos(warpSegmentAngle))) + ((weave.WarpDiameter + weave.WeftDiameter) * (warpSegmentAngle - (float)Math.Tan(warpSegmentAngle)));

                weave.WarpsStraightLengthsInUnitCell[i] += warpSegmentStraightLength;
                weave.WarpsCurvedLengthsInUnitCell[i] += warpSegmentCurvedLength;

                weave.SumOfWarpsStraightLengthsInUnitCell += warpSegmentStraightLength;
                weave.SumOfWarpsCurvedLengthsInUnitCell += warpSegmentCurvedLength;
            }
        }
    }

    private void DefinePathPointsForEachWeft()
    {
        weave.WeftsPathPointsInUnitCell = new PointF[weave.NumberOfWefts, weave.NumberOfWarps + 2];

        for (int i = 0; i < weave.NumberOfWefts; i++)
        {
            // First path point
            float firstPointY = weave.IsWarpOverWeft[0, i] ? -weave.WarpDiameter / 2 : weave.WarpDiameter / 2;
            weave.WeftsPathPointsInUnitCell[i, 0] = (new PointF(0, firstPointY));

            // Middle path points
            for (int j = 0; j < weave.NumberOfWarps; j++)
            {
                float weftXAtInterlacement = (j * weave.WarpSpacing) + (weave.WarpSpacing / 2);
                float weftYAtInterlacement;

                if (weave.IsWarpOverWeft[j, i])
                {
                    weftYAtInterlacement = -weave.WarpDiameter / 2;
                }
                else
                {
                    weftYAtInterlacement = weave.WarpDiameter / 2;
                }

                weave.WeftsPathPointsInUnitCell[i, j + 1] = (new PointF(weftXAtInterlacement, weftYAtInterlacement));
            }

            // Last path point
            int lastPointIndex = weave.WeftsPathPointsInUnitCell.GetLength(1) - 1;
            weave.WeftsPathPointsInUnitCell[i, lastPointIndex] = (new PointF(weave.WeftsPathPointsInUnitCell[i, lastPointIndex - 1].X + weave.WarpSpacing / 2, weave.WeftsPathPointsInUnitCell[i, lastPointIndex - 1].Y));
        }
    }

    private void CalculateLengthsOfEachWeft()
    {
        weave.SumOfWeftsStraightLengthsInUnitCell = 0;
        weave.SumOfWeftsCurvedLengthsInUnitCell = 0;

        weave.WeftsStraightLengthsInUnitCell = new float[weave.NumberOfWefts];
        weave.WeftsCurvedLengthsInUnitCell = new float[weave.NumberOfWefts];

        for (int i = 0; i < weave.NumberOfWefts; i++)
        {
            for (int j = 0; j < weave.NumberOfWarps + 1; j++)
            {
                float weftSegmentAngle = (float)Math.Atan(Math.Abs((weave.WeftsPathPointsInUnitCell[i, j + 1].Y - weave.WeftsPathPointsInUnitCell[i, j].Y) / (weave.WeftsPathPointsInUnitCell[i, j + 1].X - weave.WeftsPathPointsInUnitCell[i, j].X)));
                float weftSegmentStraightLength = Math.Abs(weave.WeftsPathPointsInUnitCell[i, j + 1].X - weave.WeftsPathPointsInUnitCell[i, j].X);
                float weftSegmentCurvedLength = (weftSegmentStraightLength * (1 / (float)Math.Cos(weftSegmentAngle))) + ((weave.WarpDiameter + weave.WeftDiameter) * (weftSegmentAngle - (float)Math.Tan(weftSegmentAngle)));

                weave.WeftsStraightLengthsInUnitCell[i] += weftSegmentStraightLength;
                weave.WeftsCurvedLengthsInUnitCell[i] += weftSegmentCurvedLength;

                weave.SumOfWeftsStraightLengthsInUnitCell += weftSegmentStraightLength;
                weave.SumOfWeftsCurvedLengthsInUnitCell += weftSegmentCurvedLength;
            }
        }
    }

    private void CalculateCrimp()
    {
        CalculateCrimpInWarpsDirection();
        CalculateCrimpInWeftsDirection();
    }

    private void CalculateCrimpInWarpsDirection()
    {
        weave.CrimpOfEachWarp = new float[weave.NumberOfWarps];

        for (int i = 0; i < weave.NumberOfWarps; i++)
        {
            weave.CrimpOfEachWarp[i] = ((weave.WarpsCurvedLengthsInUnitCell[i] - weave.WarpsStraightLengthsInUnitCell[i]) / weave.WarpsStraightLengthsInUnitCell[i]) * 100;
        }

        weave.UnitCellCrimpInWarpsDirection = ((weave.SumOfWarpsCurvedLengthsInUnitCell - weave.SumOfWarpsStraightLengthsInUnitCell) / (weave.SumOfWarpsStraightLengthsInUnitCell)) * 100;
    }

    private void CalculateCrimpInWeftsDirection()
    {
        weave.CrimpOfEachWeft = new float[weave.NumberOfWefts];

        for (int i = 0; i < weave.NumberOfWefts; i++)
        {
            weave.CrimpOfEachWeft[i] = ((weave.WeftsCurvedLengthsInUnitCell[i] - weave.WeftsStraightLengthsInUnitCell[i]) / weave.WeftsStraightLengthsInUnitCell[i]) * 100;
        }

        weave.UnitCellCrimpInWeftsDirection = ((weave.SumOfWeftsCurvedLengthsInUnitCell - weave.SumOfWeftsStraightLengthsInUnitCell) / (weave.SumOfWeftsStraightLengthsInUnitCell)) * 100;
    }

    private void CalculatePorosity()
    {
        weave.FabricVolume = weave.WeaveWidth * weave.WeaveHeight * weave.WeaveThickness;
        weave.WarpsVolume = (weave.SumOfWarpsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WarpDiameter, 2) / 4);
        weave.WeftsVolume = (weave.SumOfWeftsCurvedLengthsInUnitCell) * (float)(Math.PI * Math.Pow(weave.WeftDiameter, 2) / 4);

        weave.PorosityVolume = weave.FabricVolume - (weave.WarpsVolume + weave.WeftsVolume);
        weave.PorosityPercentage = (weave.PorosityVolume / weave.FabricVolume) * 100;
    }
}
