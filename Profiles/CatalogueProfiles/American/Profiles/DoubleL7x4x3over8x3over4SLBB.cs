namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL7x4x3over8x3over4SLBB : SingletonAmericanBase<DoubleL7x4x3over8x3over4SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L7X4X3/8X3/4SLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL7x4x3over8x3over4SLBB() { }
    }
}
