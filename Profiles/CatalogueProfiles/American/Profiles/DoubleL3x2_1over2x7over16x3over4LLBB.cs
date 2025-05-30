namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x2_1over2x7over16x3over4LLBB : SingletonAmericanBase<DoubleL3x2_1over2x7over16x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X2-1/2X7/16X3/4LLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL3x2_1over2x7over16x3over4LLBB() { }
    }
}
