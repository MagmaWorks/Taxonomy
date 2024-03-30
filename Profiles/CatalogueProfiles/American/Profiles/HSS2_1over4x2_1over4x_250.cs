using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_1over4x2_1over4x_250 : SingletonAmericanBase<HSS2_1over4x2_1over4x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2-1/4X2-1/4X.250";
        public Length Height => new Length(2.25, LengthUnit.Inch);
        public Length Width => new Length(2.25, LengthUnit.Inch);
        public Length FlatHeight => new Length(1.55, LengthUnit.Inch);
        public Length FlatWidth => new Length(1.55, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS2_1over4x2_1over4x_250() { }
    }
}
