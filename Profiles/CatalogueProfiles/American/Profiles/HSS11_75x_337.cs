using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS11_75x_337 : SingletonAmericanBase<HSS11_75x_337>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS11.75X.337";
        public Length Diameter => new Length(11.80, LengthUnit.Inch);
        public Length Thickness => new Length(0.34, LengthUnit.Inch);

        public HSS11_75x_337() { }
    }
}
