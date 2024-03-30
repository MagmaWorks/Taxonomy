using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2x2x1over8x3over8 : SingletonAmericanBase<DoubleL2x2x1over8x3over8>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2X2X1/8X3/8";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.13, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL2x2x1over8x3over8() { }
    }
}
