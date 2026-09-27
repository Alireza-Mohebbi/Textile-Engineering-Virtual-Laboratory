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
        private Graphics g;

        float[] crimpOfEachWarp;
        float totalFabricCrimpInWarpsDirection;

        float[] crimpOfEachWeft;
        float totalFabricCrimpInWeftsDirection;

        public override void Calculate(Weave weave, Graphics g)
        {
            this.weave = weave;
            this.g = g;

            CalculateCrimpInWarpsDirection();
            CalculateCrimpInWeftsDirection();
            ShowResults();
        }

        private void CalculateCrimpInWarpsDirection()
        {
            crimpOfEachWarp = new float[weave.NumberOfWarps];

            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                crimpOfEachWarp[i] = ((weave.WarpsCurvedLengthsInUnitCell[i] - weave.WarpsStraightLengthsInUnitCell[i]) / weave.WarpsStraightLengthsInUnitCell[i]) * 100;
            }

            totalFabricCrimpInWarpsDirection = ((weave.SumOfWarpsCurvedLengthsInUnitCell - weave.SumOfWarpsStraightLengthsInUnitCell) / (weave.SumOfWarpsStraightLengthsInUnitCell)) * 100;
        }

        private void CalculateCrimpInWeftsDirection()
        {
            crimpOfEachWeft = new float[weave.NumberOfWefts];

            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                crimpOfEachWeft[i] = ((weave.WeftsCurvedLengthsInUnitCell[i] - weave.WeftsStraightLengthsInUnitCell[i]) / weave.WeftsStraightLengthsInUnitCell[i]) * 100;
            }

            totalFabricCrimpInWeftsDirection = ((weave.SumOfWeftsCurvedLengthsInUnitCell - weave.SumOfWeftsStraightLengthsInUnitCell) / (weave.SumOfWeftsStraightLengthsInUnitCell)) * 100;
        }

        protected override void ShowResults()
        {
            g.ResetTransform();

            // Title
            g.DrawString(
                "Crimp Calculated Parameters:",
                new Font("Arial", 15, FontStyle.Bold),
                Brushes.Black,
                20,
                20);

            // Print crimp values in warps direction
            string warpsCrimpResults = "";
            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                warpsCrimpResults += ("Warp " + (i + 1) + " crimp: " + crimpOfEachWarp[i]) + "%" + "\n";
            }
            g.DrawString(
                warpsCrimpResults + "\nFabric total crimp in warp direction = " + totalFabricCrimpInWarpsDirection.ToString() + "%",
                new Font("Arial", 10),
                Brushes.Black,
                20,
                60);

            // Print crimp values in wefts direction
            string weftsCrimpResults = "";
            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                weftsCrimpResults += ("Weft " + (i + 1) + " crimp: " + crimpOfEachWeft[i]) + "%" + "\n";
            }
            g.DrawString(
                weftsCrimpResults + "\nFabric total crimp in weft direction = " + totalFabricCrimpInWeftsDirection.ToString() + "%",
                new Font("Arial", 10),
                Brushes.Black,
                500,
                60);
        }
    }
}