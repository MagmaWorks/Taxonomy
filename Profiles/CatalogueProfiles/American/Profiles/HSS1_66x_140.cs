using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS1_66x_140 : SingletonAmericanBase<HSS1_66x_140>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS1.66X.140";
        public Length Diameter => new Length(1.66, LengthUnit.Inch);
        public Length Thickness => new Length(0.14, LengthUnit.Inch);

        public HSS1_66x_140() { }
    }
}
