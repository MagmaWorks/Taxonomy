using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x3_1over2x5over16x3over8SLBB : SingletonAmericanBase<DoubleL6x3_1over2x5over16x3over8SLBB>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X3-1/2X5/16X3/8SLBB";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL6x3_1over2x5over16x3over8SLBB() { }
    }
}
