using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS1_9x_145 : SingletonAmericanBase<HSS1_9x_145>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS1.9X.145";
        public Length Diameter => new Length(1.90, LengthUnit.Inch);
        public Length Thickness => new Length(0.15, LengthUnit.Inch);

        public HSS1_9x_145() { }
    }
}
