using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Fire
{
    public interface ITemperatureField
    {
        public IList<ILocalPoint2d> Points { get; }
        public Temperature TemperatureLevel { get; }
    }
}
