using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x2x3over16x3over8SLBB : SingletonAmericanBase<DoubleL2_1over2x2x3over16x3over8SLBB>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X2X3/16X3/8SLBB";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL2_1over2x2x3over16x3over8SLBB() { }
    }
}