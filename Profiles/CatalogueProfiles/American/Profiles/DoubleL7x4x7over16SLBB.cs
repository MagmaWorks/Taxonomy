using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL7x4x7over16SLBB : SingletonAmericanBase<DoubleL7x4x7over16SLBB>, IAngle, IBackToBack
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L7X4X7/16SLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL7x4x7over16SLBB() { }
    }
}