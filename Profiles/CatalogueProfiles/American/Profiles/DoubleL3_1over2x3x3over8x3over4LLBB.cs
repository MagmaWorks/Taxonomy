namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3_1over2x3x3over8x3over4LLBB : SingletonAmericanBase<DoubleL3_1over2x3x3over8x3over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3-1/2X3X3/8X3/4LLBB";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL3_1over2x3x3over8x3over4LLBB() { }
    }
}
