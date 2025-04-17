namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x3_1over2x1over2x3over4SLBB : SingletonAmericanBase<DoubleL6x3_1over2x1over2x3over4SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X3-1/2X1/2X3/4SLBB";
        public Length Height => new Length(3.50, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL6x3_1over2x1over2x3over4SLBB() { }
    }
}
