using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x4x1over2SLBB : SingletonAmericanBase<DoubleL8x4x1over2SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X4X1/2SLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL8x4x1over2SLBB() { }
    }
}
