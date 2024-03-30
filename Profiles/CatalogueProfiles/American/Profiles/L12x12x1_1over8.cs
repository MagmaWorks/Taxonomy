using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L12x12x1_1over8 : SingletonAmericanBase<L12x12x1_1over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L12X12X1-1/8";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.03, LengthUnit.Inch);
        public Length ToeRadius => new Length(4.515, LengthUnit.Inch);

        public L12x12x1_1over8() { }
    }
}
