namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL4x3x1over2x3over4SLBB : SingletonAmericanBase<DoubleL4x3x1over2x3over4SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L4X3X1/2X3/4SLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL4x3x1over2x3over4SLBB() { }
    }
}
