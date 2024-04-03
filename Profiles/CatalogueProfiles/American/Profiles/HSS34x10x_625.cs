using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS34x10x_625 : SingletonAmericanBase<HSS34x10x_625>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS34X10X.625";
        public Length Height => new Length(34.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(32.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(8.26, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS34x10x_625() { }
    }
}
