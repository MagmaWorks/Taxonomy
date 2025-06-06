namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL5x5x5over8x3over8 : SingletonAmericanBase<DoubleL5x5x5over8x3over8>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L5X5X5/8X3/8";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL5x5x5over8x3over8() { }
    }
}
