using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3x2_1over2x1over2 : SingletonAmericanBase<L3x2_1over2x1over2>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3X2-1/2X1/2";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.62, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.81, LengthUnit.Inch);

        public L3x2_1over2x1over2() { }
    }
}