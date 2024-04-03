using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x12x_250 : SingletonAmericanBase<HSS14x12x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X12X.250";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(13.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(11.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS14x12x_250() { }
    }
}
