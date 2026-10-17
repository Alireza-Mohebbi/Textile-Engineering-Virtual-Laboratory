using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.PredictiveModel
{
    public interface IPredictiveModel
    {
        Weave CalculateYarnDiameter();
        Weave CalculateYarnSpacing();
        Weave DefinePathPointsForEachWarp();
        Weave CalculateLengthsOfEachWarp();
        Weave DefinePathPointsForEachWeft();
        Weave CalculateLengthsOfEachWeft();
        Weave CalculateCrimpInWarpsDirection();
        Weave CalculateCrimpInWeftsDirection();
        Weave CalculatePorosity();
        Weave CalculateCoverFactor();
        Weave CalculateArealWeight();
        Weave CalculateRequiredYarnLengthForFabric(float fabricLengthInWarpDirection, float fabricLengthInWeftDirection);
    }
}