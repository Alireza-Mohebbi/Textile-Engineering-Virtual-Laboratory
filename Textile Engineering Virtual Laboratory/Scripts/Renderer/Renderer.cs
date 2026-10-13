using System.Drawing;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Renderer
{
    public abstract class AbstractRenderer
    {
        protected Font titleFont = new Font("Arial", 20, FontStyle.Bold);
        protected Brush titleColor = Brushes.Black;

        protected Font textFont = new Font("Arial", 15);
        protected Brush textColor = Brushes.Black;

        protected const int decimalPlaces = 2;

        public abstract void Draw(Weave weave, Graphics g);
    }
}
