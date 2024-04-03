using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x6x5over8 : SingletonAmericanBase<L8x6x5over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X6X5/8";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.25, LengthUnit.Inch);

        public L8x6x5over8() { }
    }
}
