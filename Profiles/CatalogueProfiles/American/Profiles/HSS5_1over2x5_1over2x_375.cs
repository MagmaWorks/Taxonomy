using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS5_1over2x5_1over2x_375 : SingletonAmericanBase<HSS5_1over2x5_1over2x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS5-1/2X5-1/2X.375";
        public Length Height => new Length(5.50, LengthUnit.Inch);
        public Length Width => new Length(5.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(4.45, LengthUnit.Inch);
        public Length FlatWidth => new Length(4.45, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS5_1over2x5_1over2x_375() { }
    }
}
