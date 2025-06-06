namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL7x4x1over2x3over8LLBB : SingletonAmericanBase<DoubleL7x4x1over2x3over8LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L7X4X1/2X3/8LLBB";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL7x4x1over2x3over8LLBB() { }
    }
}
