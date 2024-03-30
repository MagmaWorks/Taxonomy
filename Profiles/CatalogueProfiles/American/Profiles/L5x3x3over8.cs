using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L5x3x3over8 : SingletonAmericanBase<L5x3x3over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L5X3X3/8";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.81, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.905, LengthUnit.Inch);

        public L5x3x3over8() { }
    }
}
