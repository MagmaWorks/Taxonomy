using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HSS3x_203 : SingletonAmericanBase<HSS3x_203>, ICircularHollow
    {
        public override AmericanShape Shape => AmericanShape.HSS;
        public override string Label => "HSS3X.203";
        public Length Diameter => new Length(3.00, LengthUnit.Inch);
        public Length Thickness => new Length(0.20, LengthUnit.Inch);

        public HSS3x_203() { }
    }
}
