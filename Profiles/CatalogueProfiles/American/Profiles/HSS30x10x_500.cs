using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS30x10x_500 : SingletonAmericanBase<HSS30x10x_500>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS30X10X.500";
        public Length Height => new Length(30.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(28.60, LengthUnit.Inch);
        public Length FlatWidth => new Length(8.61, LengthUnit.Inch);
        public Length Thickness => new Length(0.50, LengthUnit.Inch);

        public HSS30x10x_500() { }
    }
}
