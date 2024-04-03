using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS8x2x_500 : SingletonAmericanBase<HSS8x2x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS8X2X.500";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(6.61, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.605, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS8x2x_500() { }
    }
}
