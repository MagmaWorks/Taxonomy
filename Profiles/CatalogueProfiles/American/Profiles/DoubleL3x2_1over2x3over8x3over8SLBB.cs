namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x2_1over2x3over8x3over8SLBB : SingletonAmericanBase<DoubleL3x2_1over2x3over8x3over8SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X2-1/2X3/8X3/8SLBB";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL3x2_1over2x3over8x3over8SLBB() { }
    }
}
