using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x2_1over2x3over16 : SingletonAmericanBase<DoubleL2_1over2x2_1over2x3over16>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X2-1/2X3/16";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL2_1over2x2_1over2x3over16() { }
    }
}
