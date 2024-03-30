using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3_1over2x3x1over4 : SingletonAmericanBase<L3_1over2x3x1over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3-1/2X3X1/4";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.62, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.31, LengthUnit.Inch);

        public L3_1over2x3x1over4() { }
    }
}
