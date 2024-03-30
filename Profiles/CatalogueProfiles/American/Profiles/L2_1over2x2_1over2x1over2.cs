using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L2_1over2x2_1over2x1over2 : SingletonAmericanBase<L2_1over2x2_1over2x1over2>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L2-1/2X2-1/2X1/2";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.25, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.625, LengthUnit.Inch);

        public L2_1over2x2_1over2x1over2() { }
    }
}
