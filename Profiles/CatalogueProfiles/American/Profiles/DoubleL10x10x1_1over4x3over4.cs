using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL10x10x1_1over4x3over4 : SingletonAmericanBase<DoubleL10x10x1_1over4x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L10X10X1-1/4X3/4";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL10x10x1_1over4x3over4() { }
    }
}
