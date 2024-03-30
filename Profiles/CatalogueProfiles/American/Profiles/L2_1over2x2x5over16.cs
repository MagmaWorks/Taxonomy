using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L2_1over2x2x5over16 : SingletonAmericanBase<L2_1over2x2x5over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L2-1/2X2X5/16";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.63, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.815, LengthUnit.Inch);

        public L2_1over2x2x5over16() { }
    }
}
