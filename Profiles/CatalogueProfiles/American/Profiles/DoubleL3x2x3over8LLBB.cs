namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x2x3over8LLBB : SingletonAmericanBase<DoubleL3x2x3over8LLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X2X3/8LLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3x2x3over8LLBB() { }
    }
}
