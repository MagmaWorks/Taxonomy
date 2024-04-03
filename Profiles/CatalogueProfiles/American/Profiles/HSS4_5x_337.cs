using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4_5x_337 : SingletonAmericanBase<HSS4_5x_337>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4.5X.337";
        public Length Diameter => new Length(4.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.34, LengthUnit.Inch);

        public HSS4_5x_337() { }
    }
}
