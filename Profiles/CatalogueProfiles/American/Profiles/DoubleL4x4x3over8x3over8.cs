namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL4x4x3over8x3over8 : SingletonAmericanBase<DoubleL4x4x3over8x3over8>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L4X4X3/8X3/8";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL4x4x3over8x3over8() { }
    }
}
