using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS16x_438 : SingletonAmericanBase<HSS16x_438>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS16X.438";
        public Length Diameter => new Length(16.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.44, LengthUnit.Inch);

        public HSS16x_438() { }
    }
}
