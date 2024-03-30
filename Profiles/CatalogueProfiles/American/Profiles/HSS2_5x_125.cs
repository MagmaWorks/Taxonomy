using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_5x_125 : SingletonAmericanBase<HSS2_5x_125>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2.5X.125";
        public Length Diameter => new Length(2.50, LengthUnit.Inch);
        public Length Thickness => new Length(0.13, LengthUnit.Inch);

        public HSS2_5x_125() { }
    }
}
