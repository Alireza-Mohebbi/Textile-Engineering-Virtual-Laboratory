using System.Drawing;
using System.Drawing.Drawing2D;

namespace TextileEngineeringVirtualLaboratory.Plotter
{
    public abstract class PlotterTemplate
    {
        protected const int axesRange = 30;
        protected const int displayMargin = 600;
        protected const int displayScale = 15;

        // Plot with coordinate system
        public void Plot(Graphics g, string labelX, string labelY)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TranslateTransform(displayMargin, displayMargin);
            g.ScaleTransform(displayScale, displayScale);

            DrawCoordinateSystetm(g, labelX, labelY);
            DoPlot(g);
        }

        // Plot without coordinate system
        public void Plot(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TranslateTransform(displayMargin, displayMargin);
            g.ScaleTransform(displayScale, displayScale);

            DoPlot(g);
        }

        private void DrawCoordinateSystetm(Graphics g, string labelX, string labelY)
        {
            Font textsFont = new Font("Arial", 1);
            Pen axesPen = new Pen(Color.Black, 0.2f);
            Pen gridPen = new Pen(Color.LightGray, 0.1f);

            // Grid
            for (int x = -axesRange; x <= axesRange; x++)
            {
                g.DrawLine(gridPen, x, -axesRange, x, axesRange);
            }
            for (int y = -axesRange; y <= axesRange; y++)
            {
                g.DrawLine(gridPen, -axesRange, y, axesRange, y);
            }

            // Axes
            g.DrawLine(axesPen, -axesRange, 0, axesRange, 0);
            g.DrawLine(axesPen, 0, -axesRange, 0, axesRange);

            // Labels
            g.DrawString(labelX, textsFont, Brushes.Black, axesRange * 1.08f, 0);
            g.DrawString(labelY, textsFont, Brushes.Black, 0, -axesRange * 1.08f);
        }

        // Implementations of concrete plotters
        public abstract void DoPlot(Graphics g);
    }
}
