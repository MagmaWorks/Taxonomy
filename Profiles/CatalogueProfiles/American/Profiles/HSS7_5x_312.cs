using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7_5x_312 : SingletonAmericanBase<HSS7_5x_312>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7.5X.312";
        public Length Diameter => new Length(7.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS7_5x_312() { }
    }
}
