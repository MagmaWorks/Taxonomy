using OasysUnits;

namespace MagmaWorks.Taxonomy.Fire
{
    public interface IFireCurve
    {
        public TemperatureCurve Curve { get; }
        public HeatTransferCoefficient HeatTransferByConvectionCoefficient { get; }
        public Temperature GetTemperature(Duration time);
    }
}
