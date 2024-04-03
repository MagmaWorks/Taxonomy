using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x4x5over8LLBB : SingletonAmericanBase<DoubleL6x4x5over8LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X4X5/8LLBB";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL6x4x5over8LLBB() { }
    }
}
