using System;
using System.Collections.Generic;
using MagmaWorks.Taxonomy.Profiles;
using MathNet.Numerics.LinearAlgebra;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Fire
{
    public class TemperatureProfile : ITemperatureProfile
    {
        public IFireCurve Curve { get; set; }

        public IDictionary<Temperature, ITemperatureField> TemperatureFields
            => _temperatureFields ??= ComputeTemperatureFields();

        private IProfile _profile;
        private IDictionary<Temperature, ITemperatureField> _temperatureFields;

        private const double _boltzmannConstant = 0.7 * 5.670374419E-8;
        public TemperatureProfile(IProfile profile, TemperatureCurve fireCurve)
        {
            Curve = new FireCurve(fireCurve);
            _profile = profile;
        }

        private IDictionary<Temperature, ITemperatureField> ComputeTemperatureFields() {

        }

        private static ThermalConductivity ComputeLampda(Temperature temperature)
        {
            double l = 1.36 - 0.136 * temperature.DegreesCelsius / 100 + 0.0057 * Math.Pow(temperature.DegreesCelsius / 100, 2);
            return new ThermalConductivity(l, ThermalConductivityUnit.WattPerMeterKelvin);
        }

        private static Temperature SolveHeatEquation(Temperature temperature)
        {

            Temp[i, NY - 1] + 25 * dy / l * (Tfire - Temp[i, NY - 1]) - dt * B[i, NY - 1] / l * 0.7 * 5.6703E-8 * Math.Pow(Temp[i, NY - 1] + 273, 4);
        }

        private Vector<Temperature> 
    }
}
