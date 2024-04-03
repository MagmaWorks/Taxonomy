using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS12x12x_750 : SingletonAmericanBase<HSS12x12x_750>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS12X12X.750";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(9.91, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.91, LengthUnit.Inch);
        public Length Thickness => new Length(0.75, LengthUnit.Inch);

        public HSS12x12x_750() { }
    }
}
