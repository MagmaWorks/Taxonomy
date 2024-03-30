using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x8x_875 : SingletonAmericanBase<HSS16x8x_875>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X8X.875";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.56, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS16x8x_875() { }
    }
}
