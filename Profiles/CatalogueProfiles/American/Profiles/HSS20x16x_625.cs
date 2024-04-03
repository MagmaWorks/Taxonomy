using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x16x_625 : SingletonAmericanBase<HSS20x16x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X16X.625";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(18.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(14.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS20x16x_625() { }
    }
}
