using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L10x10x1_1over4 : SingletonAmericanBase<L10x10x1_1over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L10X10X1-1/4";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(6.7, LengthUnit.Inch);
        public Length ToeRadius => new Length(3.35, LengthUnit.Inch);

        public L10x10x1_1over4() { }
    }
}
