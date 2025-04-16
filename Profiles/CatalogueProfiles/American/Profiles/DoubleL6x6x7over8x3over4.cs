namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x6x7over8x3over4 : SingletonAmericanBase<DoubleL6x6x7over8x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X6X7/8X3/4";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.88, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL6x6x7over8x3over4() { }
    }
}
