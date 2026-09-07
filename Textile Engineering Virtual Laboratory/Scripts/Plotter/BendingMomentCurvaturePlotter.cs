using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TextileEngineeringVirtualLaboratory.Plotter
{
    public partial class BendingMomentCurvaturePlotter : PlotterTemplate
    {
        private float moment1, moment2;         // (N.mm)
        private float curvature1, curvature2;   // (mm^-1)

        public BendingMomentCurvaturePlotter(float moment1, float moment2, float curvature1, float curvature2)
        {
            this.moment1 = moment1;
            this.moment2 = moment2;
            this.curvature1 = curvature1;
            this.curvature2 = curvature2;
        }

        public override void DoPlot(Graphics g)
        {
            // Curve approximation formula: M = a * c^b
            // M: Moment, C: Curvature, a and b: Experimental constants

            float b = (float)((Math.Log(moment1) - Math.Log(moment2)) / (Math.Log(curvature1) - Math.Log(curvature2)));
            float a = (float)(moment1 / Math.Pow(curvature1, b));
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