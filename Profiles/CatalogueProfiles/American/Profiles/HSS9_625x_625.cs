using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS9_625x_625 : SingletonAmericanBase<HSS9_625x_625>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS9.625X.625";
        public Length Diameter => new Length(9.63, LengthUnit.Inch);
        public Length Thickness => new Length(0.63, LengthUnit.Inch);

        public HSS9_625x_625() { }
    }
}
