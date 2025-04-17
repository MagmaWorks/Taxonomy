namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x2x1over4LLBB : SingletonAmericanBase<DoubleL2_1over2x2x1over4LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X2X1/4LLBB";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL2_1over2x2x1over4LLBB() { }
    }
}
