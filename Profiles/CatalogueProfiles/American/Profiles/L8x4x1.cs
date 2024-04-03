using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x4x1 : SingletonAmericanBase<L8x4x1>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X4X1";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.25, LengthUnit.Inch);

        public L8x4x1() { }
    }
}
