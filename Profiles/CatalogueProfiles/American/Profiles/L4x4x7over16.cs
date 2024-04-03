using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class L4x4x7over16 : SingletonAmericanBase<L4x4x7over16>, ILeg
    {
        public override AmericanShape Shape => AmericanShape.L;
        public override string Label => "L4X4X7/16";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(-0.37, LengthUnit.Inch);
        public Length ToeRadius => new Length(-0.185, LengthUnit.Inch);

        public L4x4x7over16() { }
    }
}
