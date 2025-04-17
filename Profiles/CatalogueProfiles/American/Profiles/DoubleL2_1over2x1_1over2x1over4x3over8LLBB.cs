namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL2_1over2x1_1over2x1over4x3over8LLBB : SingletonAmericanBase<DoubleL2_1over2x1_1over2x1over4x3over8LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L2-1/2X1-1/2X1/4X3/8LLBB";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(1.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL2_1over2x1_1over2x1over4x3over8LLBB() { }
    }
}
