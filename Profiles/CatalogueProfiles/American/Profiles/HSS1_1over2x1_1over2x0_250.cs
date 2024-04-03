using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS1_1over2x1_1over2x0_250 : SingletonAmericanBase<HSS1_1over2x1_1over2x0_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS1-1/2X1-1/2X0.250";
        public Length Height => new Length(1.50, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(0.80, LengthUnit.Inch);
        public Length FlatWidth => new Length(0.801, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS1_1over2x1_1over2x0_250() { }
    }
}
