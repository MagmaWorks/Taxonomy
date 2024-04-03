using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x8x1_1over8 : SingletonAmericanBase<L8x8x1_1over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X8X1-1/8";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.62, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.31, LengthUnit.Inch);

        public L8x8x1_1over8() { }
    }
}
