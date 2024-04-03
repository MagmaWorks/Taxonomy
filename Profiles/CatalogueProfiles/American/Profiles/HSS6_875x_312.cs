using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6_875x_312 : SingletonAmericanBase<HSS6_875x_312>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6.875X.312";
        public Length Diameter => new Length(6.88, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS6_875x_312() { }
    }
}
