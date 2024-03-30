using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x2x5over16x3over4LLBB : SingletonAmericanBase<DoubleL2_1over2x2x5over16x3over4LLBB>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X2X5/16X3/4LLBB";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL2_1over2x2x5over16x3over4LLBB() { }
    }
}
