using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x6x9over16x3over4SLBB : SingletonAmericanBase<DoubleL8x6x9over16x3over4SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X6X9/16X3/4SLBB";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.56, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL8x6x9over16x3over4SLBB() { }
    }
}
