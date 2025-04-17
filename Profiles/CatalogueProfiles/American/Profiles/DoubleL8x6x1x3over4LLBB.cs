namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x6x1x3over4LLBB : SingletonAmericanBase<DoubleL8x6x1x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X6X1X3/4LLBB";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL8x6x1x3over4LLBB() { }
    }
}
