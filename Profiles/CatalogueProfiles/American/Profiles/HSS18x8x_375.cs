using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS18x8x_375 : SingletonAmericanBase<HSS18x8x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS18X8X.375";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.00, LengthUnit.Inch);
        public Length FlatWidth => new Length(6.95, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS18x8x_375() { }
    }
}
