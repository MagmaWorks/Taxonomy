namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3_1over2x2_1over2x1over4LLBB : SingletonAmericanBase<DoubleL3_1over2x2_1over2x1over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3-1/2X2-1/2X1/4LLBB";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(2.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3_1over2x2_1over2x1over4LLBB() { }
    }
}
