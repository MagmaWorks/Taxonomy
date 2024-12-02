using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Fire
{
    public interface ITemperatureProfile
    {
        public IFireCurve Curve { get; }
        public IDictionary<Temperature, ITemperatureField> TemperatureFields { get; }
    }
}
