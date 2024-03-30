using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3_1over2x3_1over2x_313 : SingletonAmericanBase<HSS3_1over2x3_1over2x_313>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3-1/2X3-1/2X.313";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlatHeight => new Length(2.63, LengthUnit.Inch);
        public Length FlatWidth => new Length(2.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.31, LengthUnit.Inch);

        public HSS3_1over2x3_1over2x_313() { }
    }
}
