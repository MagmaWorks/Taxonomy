namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL4x3x5over8x3over4LLBB : SingletonAmericanBase<DoubleL4x3x5over8x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L4X3X5/8X3/4LLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL4x3x5over8x3over4LLBB() { }
    }
}
