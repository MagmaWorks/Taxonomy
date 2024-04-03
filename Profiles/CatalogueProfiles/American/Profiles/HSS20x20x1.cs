using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS20x20x1 : SingletonAmericanBase<HSS20x20x1>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS20X20X1";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(20.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(17.20, LengthUnit.Inch);
        public Length FlatWidth => new Length(17.2, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS20x20x1() { }
    }
}
