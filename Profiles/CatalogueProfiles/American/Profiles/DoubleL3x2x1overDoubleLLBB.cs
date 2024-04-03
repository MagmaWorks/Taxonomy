using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x2x1overDoubleLLBB : SingletonAmericanBase<DoubleL3x2x1overDoubleLLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X2X1/2LLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3x2x1overDoubleLLBB() { }
    }
}
