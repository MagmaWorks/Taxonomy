using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L6x6x7over8 : SingletonAmericanBase<L6x6x7over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L6X6X7/8";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.74, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.87, LengthUnit.Inch);

        public L6x6x7over8() { }
    }
}
