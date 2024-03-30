using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS24x_875 : SingletonAmericanBase<HSS24x_875>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS24X.875";
        public Length Diameter => new Length(24.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.88, LengthUnit.Inch);

        public HSS24x_875() { }
    }
}
