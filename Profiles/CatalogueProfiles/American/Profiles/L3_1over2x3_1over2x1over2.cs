using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3_1over2x3_1over2x1over2 : SingletonAmericanBase<L3_1over2x3_1over2x1over2>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3-1/2X3-1/2X1/2";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.12, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.06, LengthUnit.Inch);

        public L3_1over2x3_1over2x1over2() { }
    }
}
