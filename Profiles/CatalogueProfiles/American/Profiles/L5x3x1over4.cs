using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L5x3x1over4 : SingletonAmericanBase<L5x3x1over4>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L5X3X1/4";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.06, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.03, LengthUnit.Inch);

        public L5x3x1over4() { }
    }
}