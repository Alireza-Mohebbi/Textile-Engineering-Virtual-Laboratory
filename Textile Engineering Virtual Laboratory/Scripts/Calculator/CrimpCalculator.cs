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

        public override void Calculate(Weave weave)
        {
            this.weave = weave;
            CalculateCrimpInWarpsDirection();
            CalculateCrimpInWeftsDirection();
        }

        private void CalculateCrimpInWarpsDirection()
        {
            float[] crimpOfEachWarp = new float[weave.NumberOfWarps];
            float totalFabricCrimpInWarpsDirection = 0;

            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                crimpOfEachWarp[i] = ((weave.WarpsCurvedLengthsInUnitCell[i] - weave.WarpsStraightLengthsInUnitCell[i]) / weave.WarpsStraightLengthsInUnitCell[i]) * 100;
            }

            totalFabricCrimpInWarpsDirection = ((weave.SumOfWarpsCurvedLengthsInUnitCell - weave.SumOfWarpsStraightLengthsInUnitCell) / (weave.SumOfWarpsStraightLengthsInUnitCell)) * 100;

            // Print crimp values
            string messageNew = "";
            for (int i = 0; i < weave.NumberOfWarps; i++)
            {
                messageNew += ("Warp " + (i + 1) + " crimp: " + crimpOfEachWarp[i]) + "%" + "\n";
            }

            MessageBox.Show(messageNew + "\nFabric total crimp in warp direction = " + totalFabricCrimpInWarpsDirection.ToString() + "%");
        }

        private void CalculateCrimpInWeftsDirection()
        {
            float[] crimpOfEachWeft = new float[weave.NumberOfWefts];
            float totalFabricCrimpInWeftsDirection = 0;

            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                crimpOfEachWeft[i] = ((weave.WeftsCurvedLengthsInUnitCell[i] - weave.WeftsStraightLengthsInUnitCell[i]) / weave.WeftsStraightLengthsInUnitCell[i]) * 100;
            }

            totalFabricCrimpInWeftsDirection = ((weave.SumOfWeftsCurvedLengthsInUnitCell - weave.SumOfWeftsStraightLengthsInUnitCell) / (weave.SumOfWeftsStraightLengthsInUnitCell)) * 100;

            // Print crimp values
            string messageNew = "";
            for (int i = 0; i < weave.NumberOfWefts; i++)
            {
                messageNew += ("Weft " + (i + 1) + " crimp: " + crimpOfEachWeft[i]) + "%" + "\n";
            }

            MessageBox.Show(messageNew + "\nFabric total crimp in weft direction = " + totalFabricCrimpInWeftsDirection.ToString() + "%");
        }
    }
}