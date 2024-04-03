using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS4x_237 : SingletonAmericanBase<HSS4x_237>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS4X.237";
        public Length Diameter => new Length(4.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.24, LengthUnit.Inch);

        public HSS4x_237() { }
    }
}
