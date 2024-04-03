using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x16x_250 : SingletonAmericanBase<HSS22x16x_250>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X16X.250";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.30, LengthUnit.Inch);
        public Length FlatWidth => new Length(15.3, LengthUnit.Inch);
        public Length Thickness => new Length(0.25, LengthUnit.Inch);

        public HSS22x16x_250() { }
    }
}
