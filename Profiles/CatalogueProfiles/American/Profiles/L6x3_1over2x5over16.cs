using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L6x3_1over2x5over16 : SingletonAmericanBase<L6x3_1over2x5over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L6X3-1/2X5/16";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.88, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.44, LengthUnit.Inch);

        public L6x3_1over2x5over16() { }
    }
}
