using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x22x1 : SingletonAmericanBase<HSS22x22x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X22X1";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(22.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(19.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(19.2, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS22x22x1() { }
    }
}
