using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L8x4x7over8 : SingletonAmericanBase<L8x4x7over8>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L8X4X7/8";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.74, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.87, LengthUnit.Inch);

        public L8x4x7over8() { }
    }
}
