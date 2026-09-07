using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TextileEngineeringVirtualLaboratory.Plotter
{
    public partial class ShearStiffnessPlotter : PlotterTemplate
    {
        private float shearStress1, shearStress2;     // (MPa)
        private float shearStrain1, shearStrain2;

        public ShearStiffnessPlotter(float shearStress1, float shearStress2, float shearStrain1, float shearStrain2)
        {
            this.shearStress1 = shearStress1;
            this.shearStress2 = shearStress2;
            this.shearStrain1 = shearStrain1;
            this.shearStrain2 = shearStrain2;
        }

        public override void DoPlot(Graphics g)
        {
            // Curve approximation formula: Stress = a * Strain^b
            // a and b: Experimental constants

            float b = ((float)Math.Log(shearStress1) - (float)Math.Log(shearStress2)) / ((float)Math.Log(shearStrain1) - (float)Math.Log(shearStrain2));
            float a = shearStress1 / (float)Math.Pow(shearStrain1, b);
            List<PointF> points = new List<PointF>();

            for (int x = 0; x < axesRange; x++)
            {
                float y = (float)(a * Math.Pow(x, b));
                if (y > axesRange)
                {
                    break;
                }
                points.Add(new PointF(x, -y));  // The negative in '-y' is because Y component of screen coord is inverse
            }

            try
            {
                using (Pen pen = new Pen(Color.Blue, 0.5f))
                {
                    g.DrawCurve(pen, points.ToArray());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values. Please check the inputs.");
            }

        }
    }
}