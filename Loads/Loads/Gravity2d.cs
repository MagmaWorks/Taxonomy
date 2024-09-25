using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads
{
    public class Gravity2d : IGravity2d
    {
        public char Symbol { get; set; } = 'G';
        public Ratio X { get; set; } = Ratio.Zero;
        public Ratio Z { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);

        public Gravity2d() { }

        public Gravity2d(Ratio z)
        {
            Z = z;
        }
    }
}
