using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS2_375x_218 : SingletonAmericanBase<HSS2_375x_218>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS2.375X.218";
        public Length Diameter => new Length(2.38, LengthUnit.Inch);
        public Length Thickness => new Length(0.22, LengthUnit.Inch);

        public HSS2_375x_218() { }
    }
}
