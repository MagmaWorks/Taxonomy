using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL4x3_1over2x1over4x3over4LLBB : SingletonAmericanBase<DoubleL4x3_1over2x1over4x3over4LLBB>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L4X3-1/2X1/4X3/4LLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL4x3_1over2x1over4x3over4LLBB() { }
    }
}
