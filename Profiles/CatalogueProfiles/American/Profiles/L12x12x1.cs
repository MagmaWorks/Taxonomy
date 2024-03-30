using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L12x12x1 : SingletonAmericanBase<L12x12x1>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L12X12X1";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.29, LengthUnit.Inch);
        public Length ToeRadius => new Length(4.645, LengthUnit.Inch);

        public L12x12x1() { }
    }
}
