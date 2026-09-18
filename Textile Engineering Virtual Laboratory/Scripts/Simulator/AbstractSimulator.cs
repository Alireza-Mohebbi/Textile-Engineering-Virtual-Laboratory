using System.Drawing;

namespace TextileEngineeringVirtualLaboratory.Simulator
{
    public abstract class AbstractSimulator
    {
        protected const int axesRange = 30;
        protected const int displayMargin = 700;
        protected const int displayScale = 15;

        public abstract void Simulate(Graphics g);
    }
}
