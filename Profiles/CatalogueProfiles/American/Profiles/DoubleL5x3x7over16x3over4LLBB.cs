namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL5x3x7over16x3over4LLBB : SingletonAmericanBase<DoubleL5x3x7over16x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L5X3X7/16X3/4LLBB";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL5x3x7over16x3over4LLBB() { }
    }
}
