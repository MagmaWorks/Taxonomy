namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL5x3_1over2x5over8x3over8SLBB : SingletonAmericanBase<DoubleL5x3_1over2x5over8x3over8SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L5X3-1/2X5/8X3/8SLBB";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL5x3_1over2x5over8x3over8SLBB() { }
    }
}
