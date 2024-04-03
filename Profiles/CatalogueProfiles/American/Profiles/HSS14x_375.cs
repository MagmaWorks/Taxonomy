using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS14x_375 : SingletonAmericanBase<HSS14x_375>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS14X.375";
        public Length Diameter => new Length(14.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.38, LengthUnit.Inch);

        public HSS14x_375() { }
    }
}
