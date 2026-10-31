using System.Drawing;
using TextileEngineeringVirtualLaboratory.CrossSection;
using TextileEngineeringVirtualLaboratory.Materials;

namespace TextileEngineeringVirtualLaboratory.Textiles
{
    public class Weave
    {
        /// Weave physical properties ///
        public string Pattern { get; set; }
        public ICrossSection CrossSection { get; set; }
        //Warp
        public float WarpCount { get; set; }            // (Ne)
        public float WarpDensity { get; set; }      // (ends/mm^-1)
        public int NumberOfWarps { get; set; }
        public float WarpDiameter { get; set; }     // (mm)
        public float WarpSpacing { get; set; }      // (mm)
        // Weft
        public float WeftCount { get; set; }            // (Ne)
        public float WeftDensity { get; set; }      // (picks/mm^-1)
        public int NumberOfWefts { get; set; }
        public float WeftDiameter { get; set; }     // (mm)
        public float WeftSpacing { get; set; }      // (mm)
        // Fabric
        IMaterials Material;
        public float YarnDiameter { get; set; }     // (mm)
        public float YarnSpacing { get; set; }      // (mm)
        public bool[,] IsWarpOverWeft { get; set; }
        public int NumberOfLayers { get { return 1; } }
        public float UnitCellLengthInWarpDirection { get { return WeftSpacing * NumberOfWefts; } }   // (mm)

        public float UnitCellLengthInWeftDirection { get { return WarpSpacing * NumberOfWarps; } }    // (mm)
        public float FabricLengthInWarpDirection { get; set; }
        public float FabricLengthInWeftDirection { get; set; }

        public float FabricThickness { get { return NumberOfLayers * (WarpDiameter + WeftDiameter); } }  // (mm)
        public float ArealWeight { get; set; }  // (g/mm^2)
        public float CoverFactorInWarpDirection { get; set; }
        public float CoverFactorInWeftDirection { get; set; }
        public float RequiredWarpLengthForFabric { get; set; }  // (mm)
        public float RequiredWeftLengthForFabric { get; set; }  // (mm)

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
        public float UnitCellCrimpInWarpDirection { get; set; }    // (Dimensionless)
        public float[] CrimpOfEachWeft { get; set; }                // (Dimensionless)
        public float UnitCellCrimpInWeftDirection { get; set; }    // (Dimensionless)

        // Porosity properties ///
        public float FabricVolume { get; set; }         // (mm^3)
        public float WarpsVolume { get; set; }          // (mm^3)
        public float WeftsVolume { get; set; }          // (mm^3)
        public float PorosityVolume { get; set; }       // (mm^3)
        public float PorosityPercentage { get; set; }   // (%)

        public Weave(IMaterials material, string pattern, float warpCount, float weftCount, float warpDensity, float weftDensity, float fabricLengthInWarpDirection, float fabricLengthInWeftDirection)
        {
            Material = material;
            Pattern = pattern;
            WarpCount = warpCount;
            WeftCount = weftCount;
            WarpDensity = warpDensity;
            WeftDensity = weftDensity;
            FabricLengthInWarpDirection = fabricLengthInWarpDirection;
            FabricLengthInWeftDirection = fabricLengthInWeftDirection;

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