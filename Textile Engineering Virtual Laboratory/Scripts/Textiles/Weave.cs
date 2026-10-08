using System.Drawing;
using TextileEngineeringVirtualLaboratory.Materials;

namespace TextileEngineeringVirtualLaboratory.Textiles
{
    public class Weave
    {
        /// Weave physical properties ///
        public string Pattern { get; set; }
        //Warp
        public float WarpCount { get; set; }            // Ne
        public float WarpCompactness { get; set; }      // mm^-1
        public int NumberOfWarps { get; set; }
        public float WarpDiameter { get; set; }     // mm
        public float WarpSpacing { get; set; }      // mm
        // Weft
        public float WeftCount { get; set; }            // Ne
        public float WeftCompactness { get; set; }      // mm^-1
        public int NumberOfWefts { get; set; }
        public float WeftDiameter { get; set; }     // mm
        public float WeftSpacing { get; set; }      // mm
        // Fabric
        IMaterials Material;
        public float YarnDiameter { get; set; }     // (mm)
        public float YarnSpacing { get; set; }      // (mm)
        public bool[,] IsWarpOverWeft { get; set; }
        public int NumberOfLayers { get { return 1; } }
        public float FabricWidth { get { return WarpSpacing * NumberOfWarps; } }    // (mm)
        public float FabricHeight { get { return WeftSpacing * NumberOfWefts; } }   // (mm)
        public float FabricThickness { get { return NumberOfLayers * (WarpDiameter + WeftDiameter); } }  // (mm)
        public float ArialWeight { get; set; }  // (g/mm^2)

        /// Weave mechanical properties ///
        public float YoungsModulusX { get; set; }   // (MPa)
        public float YoungsModulusY { get; set; }   // (MPa)
   
        /// Global ambient properties ///
        private const float gravitaionalAcceleration = 9810;    // (mm/s^2)

        /// Warps and wefts path points and lengths ///
        public PointF[,] WarpsPathPointsInUnitCell { get; set; }
        public float[] WarpsStraightLengthsInUnitCell { get; set; }     // (mm)
        public float[] WarpsCurvedLengthsInUnitCell { get; set; }       // (mm)
        public float SumOfWarpsStraightLengthsInUnitCell { get; set; }  // (mm)
        public float SumOfWarpsCurvedLengthsInUnitCell { get; set; }    // (mm)
        public PointF[,] WeftsPathPointsInUnitCell { get; set; }
        public float[] WeftsStraightLengthsInUnitCell { get; set; }     // (mm)
        public float[] WeftsCurvedLengthsInUnitCell { get; set; }       // (mm)
        public float SumOfWeftsStraightLengthsInUnitCell { get; set; }  // (mm)
        public float SumOfWeftsCurvedLengthsInUnitCell { get; set; }    // (mm)

        /// Crimp properties ///
        public float[] CrimpOfEachWarp { get; set; }                // (Dimensionless
        public float UnitCellCrimpInWarpsDirection { get; set; }    // (Dimensionless)
        public float[] CrimpOfEachWeft { get; set; }                // (Dimensionless)
        public float UnitCellCrimpInWeftsDirection { get; set; }    // (Dimensionless)

        // Porosity properties ///
        public float FabricVolume { get; set; }
        public float WarpsVolume { get; set; }
        public float WeftsVolume { get; set; }
        public float PorosityVolume { get; set; }
        public float PorosityPercentage { get; set; }

        public Weave(string pattern, float warpCount, float weftCount, float warpCompactness, float weftCompactness, IMaterials material)
        {
            Pattern = pattern;
            WarpCount = warpCount;
            WeftCount = weftCount;
            WarpCompactness = warpCompactness;
            WeftCompactness = weftCompactness;
            Material = material;

            MakeInterlacementMatrix();
        }

        private void MakeInterlacementMatrix()
        {
            switch (Pattern)
            {
                case "Plain 1/1":
                    NumberOfWarps = 2;
                    NumberOfWefts = 2;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] = (i + j) % 2 == 0;
                        }
                    }
                    break;

                case "Basket 2/2":
                    NumberOfWarps = 4;
                    NumberOfWefts = 4;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (i / 2 + j / 2) % 2 == 0;
                        }
                    }
                    break;

                case "Twill 2/1":
                    NumberOfWarps = 3;
                    NumberOfWefts = 3;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (j - i + NumberOfWefts) % NumberOfWefts < 2;
                        }
                    }
                    break;

                case "Twill 1/2":
                    NumberOfWarps = 3;
                    NumberOfWefts = 3;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (j - i + NumberOfWefts) % NumberOfWefts < 1;
                        }
                    }
                    break;

                case "Twill 2/2":
                    NumberOfWarps = 4;
                    NumberOfWefts = 4;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (j - i + NumberOfWefts) % NumberOfWefts < 2;
                        }
                    }
                    break;

                case "Twill 3/1":
                    NumberOfWarps = 4;
                    NumberOfWefts = 4;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (j - i + NumberOfWefts) % NumberOfWefts < 3;
                        }
                    }
                    break;

                case "Twill 3/2":
                    NumberOfWarps = 5;
                    NumberOfWefts = 5;
                    IsWarpOverWeft = new bool[NumberOfWarps, NumberOfWefts];
                    for (int i = 0; i < NumberOfWarps; i++)
                    {
                        for (int j = 0; j < NumberOfWefts; j++)
                        {
                            IsWarpOverWeft[i, j] =
                                (j - i + NumberOfWefts) % NumberOfWefts < 3;
                        }
                    }
                    break;

                default:
                    goto case "Plain 1/1";
            }
        }
    }
}