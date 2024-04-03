using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_1over2x2_1over2x_313 : SingletonAmericanBase<HSS2_1over2x2_1over2x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2-1/2X2-1/2X.313";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(1.63, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS2_1over2x2_1over2x_313() { }
    }
}
