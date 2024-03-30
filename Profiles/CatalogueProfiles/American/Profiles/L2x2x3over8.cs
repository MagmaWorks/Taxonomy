using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L2x2x3over8 : SingletonAmericanBase<L2x2x3over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L2X2X3/8";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.99, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.495, LengthUnit.Inch);

        public L2x2x3over8() { }
    }
}
