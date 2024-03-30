using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS6x5x_500 : SingletonAmericanBase<HSS6x5x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS6X5X.500";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(4.61, LengthUnit.Inch);
        public Length FlatWidth => new Length(3.60, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS6x5x_500() { }
    }
}
