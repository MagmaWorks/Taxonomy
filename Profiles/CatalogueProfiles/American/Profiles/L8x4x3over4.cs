using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x4x3over4 : SingletonAmericanBase<L8x4x3over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X4X3/4";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(6, LengthUnit.Inch);
        public Length ToeRadius => new Length(3, LengthUnit.Inch);

        public L8x4x3over4() { }
    }
}
