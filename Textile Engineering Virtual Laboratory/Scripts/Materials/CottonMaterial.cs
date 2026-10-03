namespace WindowsFormsApplication1.Scripts.Materials
{
    public class CottonMaterial : IMaterials
    {
        public float Density { get { return 0.00154f; } }    // g/mm^3
        public float PackingFactor { get { return 1; } }    // Packing factor = 1 is only for ideal situation (circlular yarn cross section, no holes in yarn). Otherwise this value should change.
    }
}
