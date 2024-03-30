using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS30x10x1 : SingletonAmericanBase<HSS30x10x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS30X10X1";
        public Length Height => new Length(30.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(27.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(7.21, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS30x10x1() { }
    }
}
