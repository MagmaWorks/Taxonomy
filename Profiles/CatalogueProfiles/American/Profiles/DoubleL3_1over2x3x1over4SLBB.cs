using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3_1over2x3x1over4SLBB : SingletonAmericanBase<DoubleL3_1over2x3x1over4SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3-1/2X3X1/4SLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3_1over2x3x1over4SLBB() { }
    }
}
