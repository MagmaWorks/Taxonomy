using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x18x1 : SingletonAmericanBase<HSS18x18x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X18X1";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(15.2, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS18x18x1() { }
    }
}
