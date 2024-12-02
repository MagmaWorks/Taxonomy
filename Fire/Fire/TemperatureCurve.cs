using System;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Fire
{
    public class FireCurve : IFireCurve
    {
        public TemperatureCurve Curve { get; }

        public HeatTransferCoefficient HeatTransferByConvectionCoefficient
         => GetHeatTransferByConvectionCoefficient(Curve);

        public FireCurve(TemperatureCurve curve) => Curve = curve;

        public static Temperature GetTemperature(Duration time, TemperatureCurve curve)
        {
            double t = time.Minutes;
            double temperature = 20;
            switch (curve)
            {
                case TemperatureCurve.External:
                    temperature += 660 * (1 - 0.687 * Math.Exp(-0.32 * t) - 0.313 * Math.Exp(-3.8 * t));
                    break;

                case TemperatureCurve.Hydrocarbon:
                    temperature += 1080 * (1 - 0.325 * Math.Exp(-0.167 * t) - 0.675 * Math.Exp(-2.5 * t));
                    break;

                case TemperatureCurve.Standard:
                default:
                    temperature += 345 * Math.Log10(8 * t + 1);
                    break;
            }

            return new Temperature(temperature, TemperatureUnit.DegreeCelsius);
        }

        public static HeatTransferCoefficient GetHeatTransferByConvectionCoefficient(TemperatureCurve curve)
        {
            switch (curve)
            {
                case TemperatureCurve.Hydrocarbon:
                    return new HeatTransferCoefficient(50, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

                case TemperatureCurve.Standard:
                case TemperatureCurve.External:
                    return new HeatTransferCoefficient(25, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

                default:
                    return new HeatTransferCoefficient(35, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
            }
        }

        public Temperature GetTemperature(Duration time)
        {
            return GetTemperature(time, Curve);
        }
    }
}
