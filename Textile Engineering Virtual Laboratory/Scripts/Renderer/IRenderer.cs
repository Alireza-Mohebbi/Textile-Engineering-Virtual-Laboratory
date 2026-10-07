using System.Drawing;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Renderer
{
    interface IRenderer
    {
        void Draw(Weave weave, Graphics g);
    }
}
