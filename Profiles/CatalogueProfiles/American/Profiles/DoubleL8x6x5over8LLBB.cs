namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x6x5over8LLBB : SingletonAmericanBase<DoubleL8x6x5over8LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X6X5/8LLBB";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL8x6x5over8LLBB() { }
    }
}
