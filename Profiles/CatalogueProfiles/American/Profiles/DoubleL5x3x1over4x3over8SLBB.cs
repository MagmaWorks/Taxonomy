namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL5x3x1over4x3over8SLBB : SingletonAmericanBase<DoubleL5x3x1over4x3over8SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L5X3X1/4X3/8SLBB";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL5x3x1over4x3over8SLBB() { }
    }
}
