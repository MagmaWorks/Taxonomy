using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5x2_1over2x_125 : SingletonAmericanBase<HSS5x2_1over2x_125>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5X2-1/2X.125";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(4.65, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.15, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS5x2_1over2x_125() { }
    }
}
