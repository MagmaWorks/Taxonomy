namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL6x6x5over8x3over8 : SingletonAmericanBase<DoubleL6x6x5over8x3over8>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L6X6X5/8X3/8";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL6x6x5over8x3over8() { }
    }
}
