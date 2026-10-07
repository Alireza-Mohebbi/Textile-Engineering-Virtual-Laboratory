using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.PredictiveModel
{
    interface IPredictiveModel
    {
        Weave CalculateTheGetWeaveParameters(Weave weave);
    }
}