namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL3x3x1over2x3over8 : SingletonAmericanBase<DoubleL3x3x1over2x3over8>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L3X3X1/2X3/8";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.375, LengthUnit.Inch);

        public DoubleL3x3x1over2x3over8() { }
    }
}
