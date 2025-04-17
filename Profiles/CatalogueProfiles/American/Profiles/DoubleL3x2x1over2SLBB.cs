namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x2x1over2SLBB : SingletonAmericanBase<DoubleL3x2x1over2SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X2X1/2SLBB";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL3x2x1over2SLBB() { }
    }
}
