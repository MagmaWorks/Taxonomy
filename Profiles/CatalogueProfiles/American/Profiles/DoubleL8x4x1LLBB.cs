namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x4x1LLBB : SingletonAmericanBase<DoubleL8x4x1LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X4X1LLBB";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL8x4x1LLBB() { }
    }
}
