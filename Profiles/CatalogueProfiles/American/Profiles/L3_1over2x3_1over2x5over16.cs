using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L3_1over2x3_1over2x5over16 : SingletonAmericanBase<L3_1over2x3_1over2x5over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L3-1/2X3-1/2X5/16";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.25, LengthUnit.Inch);

        public L3_1over2x3_1over2x5over16() { }
    }
}
