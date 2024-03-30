using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x8x3over4 : SingletonAmericanBase<L8x8x3over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X8X3/4";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.87, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.935, LengthUnit.Inch);

        public L8x8x3over4() { }
    }
}
