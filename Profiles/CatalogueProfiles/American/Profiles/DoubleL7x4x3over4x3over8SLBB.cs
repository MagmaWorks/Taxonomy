namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL7x4x3over4x3over8SLBB : SingletonAmericanBase<DoubleL7x4x3over4x3over8SLBB>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L7X4X3/4X3/8SLBB";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL7x4x3over4x3over8SLBB() { }
    }
}
