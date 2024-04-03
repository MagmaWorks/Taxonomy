using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x12x_500 : SingletonAmericanBase<HSS20x12x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X12X.500";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(18.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(10.60, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS20x12x_500() { }
    }
}
