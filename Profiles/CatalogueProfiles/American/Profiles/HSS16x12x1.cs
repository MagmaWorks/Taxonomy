using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x12x1 : SingletonAmericanBase<HSS16x12x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X12X1";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.21, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS16x12x1() { }
    }
}
