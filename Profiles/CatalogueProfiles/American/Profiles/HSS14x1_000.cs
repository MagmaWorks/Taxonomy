using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x1_000 : SingletonAmericanBase<HSS14x1_000>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X1.000";
        public Length Diameter => new Length(14.00, LengthUnit.Inch);
        public Length Thickness => new Length(1.00, LengthUnit.Inch);

        public HSS14x1_000() { }
    }
}
