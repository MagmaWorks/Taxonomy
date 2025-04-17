namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL7x4x7over16x3over4LLBB : SingletonAmericanBase<DoubleL7x4x7over16x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L7X4X7/16X3/4LLBB";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL7x4x7over16x3over4LLBB() { }
    }
}
