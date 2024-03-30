using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L6x4x1over2 : SingletonAmericanBase<L6x4x1over2>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L6X4X1/2";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.25, LengthUnit.Inch);

        public L6x4x1over2() { }
    }
}
