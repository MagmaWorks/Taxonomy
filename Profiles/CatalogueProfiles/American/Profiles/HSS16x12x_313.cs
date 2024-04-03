using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x12x_313 : SingletonAmericanBase<HSS16x12x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X12X.313";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(15.10, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.10, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS16x12x_313() { }
    }
}
