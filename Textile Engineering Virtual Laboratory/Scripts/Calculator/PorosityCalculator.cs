using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Calculator
{
    class PorosityCalculator : AbstractCalculator
    {
        private Weave weave;

        public override void Calculate(Weave weave)
        {
            this.weave = weave;
        }

    }
}