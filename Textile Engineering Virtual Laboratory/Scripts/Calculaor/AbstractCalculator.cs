using System.Drawing;
using System.Drawing.Drawing2D;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    public abstract class AbstractCalculator
    {
        protected const int axesRange = 30;
        protected const int displayMargin = 700;
        protected const int displayScale = 15;

        public abstract void CalculateWarpsCrimp(Weave weave);
    }
}
