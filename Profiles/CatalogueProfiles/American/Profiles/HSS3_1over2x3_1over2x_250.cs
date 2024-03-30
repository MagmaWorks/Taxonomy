using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_1over2x3_1over2x_250 : SingletonAmericanBase<HSS3_1over2x3_1over2x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3-1/2X3-1/2X.250";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.80, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.80, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS3_1over2x3_1over2x_250() { }
    }
}
