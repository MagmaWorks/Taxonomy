using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS8_625x_322 : SingletonAmericanBase<HSS8_625x_322>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS8.625X.322";
        public Length Diameter => new Length(8.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.32, LengthUnit.Inch);

        public HSS8_625x_322() { }
    }
}
