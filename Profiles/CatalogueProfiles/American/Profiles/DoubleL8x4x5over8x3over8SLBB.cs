namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL8x4x5over8x3over8SLBB : SingletonAmericanBase<DoubleL8x4x5over8x3over8SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L8X4X5/8X3/8SLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL8x4x5over8x3over8SLBB() { }
    }
}
