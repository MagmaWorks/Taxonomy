namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL12x12x1 : SingletonAmericanBase<DoubleL12x12x1>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L12X12X1";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(1.00, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0, LengthUnit.Inch);

        public DoubleL12x12x1() { }
    }
}
