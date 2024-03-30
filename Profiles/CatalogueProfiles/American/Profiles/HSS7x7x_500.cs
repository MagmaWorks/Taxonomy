using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS7x7x_500 : SingletonAmericanBase<HSS7x7x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS7X7X.500";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(5.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(5.60, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS7x7x_500() { }
    }
}
