using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Fire
{
    public class TemperatureField : ITemperatureField
    {
        public IList<ILocalPoint2d> Points { get; private set; }
        public Temperature TemperatureLevel { get; private set; }

        public TemperatureField(IList<ILocalPoint2d> points, Temperature temperatureLevel)
        {
            Points = points;
            TemperatureLevel = temperatureLevel;
        }
    }
}
