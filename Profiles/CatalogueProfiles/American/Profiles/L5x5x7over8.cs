using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L5x5x7over8 : SingletonAmericanBase<L5x5x7over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L5X5X7/8";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.74, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.37, LengthUnit.Inch);

        public L5x5x7over8() { }
    }
}
