using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x10x_313 : SingletonAmericanBase<HSS18x10x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X10X.313";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.10, LengthUnit.Inch);
        public Length FlatWidth => new Length(9.13, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS18x10x_313() { }
    }
}
