using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L4x3x1over2 : SingletonAmericanBase<L4x3x1over2>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L4X3X1/2";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.62, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.31, LengthUnit.Inch);

        public L4x3x1over2() { }
    }
}
