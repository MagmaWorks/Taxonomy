using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L6x6x3over4 : SingletonAmericanBase<L6x6x3over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L6X6X3/4";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(4, LengthUnit.Inch);
        public Length ToeRadius => new Length(2, LengthUnit.Inch);

        public L6x6x3over4() { }
    }
}
