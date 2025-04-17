namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL12x12x1_1over4x3over4 : SingletonAmericanBase<DoubleL12x12x1_1over4x3over4>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L12X12X1-1/4X3/4";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(1.25, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(0.75, LengthUnit.Inch);

        public DoubleL12x12x1_1over4x3over4() { }
    }
}
