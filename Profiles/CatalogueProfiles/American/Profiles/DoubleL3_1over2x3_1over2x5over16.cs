using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3_1over2x3_1over2x5over16 : SingletonAmericanBase<DoubleL3_1over2x3_1over2x5over16>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3-1/2X3-1/2X5/16";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3_1over2x3_1over2x5over16() { }
    }
}