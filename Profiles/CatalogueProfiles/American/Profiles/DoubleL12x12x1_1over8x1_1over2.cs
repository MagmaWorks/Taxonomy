using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL12x12x1_1over8x1_1over2 : SingletonAmericanBase<DoubleL12x12x1_1over8x1_1over2>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L12X12X1-1/8X1-1/2";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.5, LengthUnit.Inch);

        public DoubleL12x12x1_1over8x1_1over2() { }
    }
}