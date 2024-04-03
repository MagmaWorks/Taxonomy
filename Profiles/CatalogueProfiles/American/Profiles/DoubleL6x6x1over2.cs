using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x6x1over2 : SingletonAmericanBase<DoubleL6x6x1over2>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X6X1/2";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL6x6x1over2() { }
    }
}
