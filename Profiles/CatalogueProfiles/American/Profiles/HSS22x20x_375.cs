using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS22x20x_375 : SingletonAmericanBase<HSS22x20x_375>, IRoundedRectangularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS22X20X.375";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(20.00, LengthUnit.Inch);
        public Length FlatHeight => new Length(21.00, LengthUnit.Inch);
        public Length FlatWidth => new Length(19.0, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS22x20x_375() { }
    }
}
