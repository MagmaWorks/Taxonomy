namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class DoubleL10x10x3over4x1_1over2 : SingletonAmericanBase<DoubleL10x10x3over4x1_1over2>, IDoubleAngle
    {
        public override AmericanShape Shape => AmericanShape.DoubleL;
        public override string Label => "2L10X10X3/4X1-1/2";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length BackToBackDistance => new Length(1.5, LengthUnit.Inch);

        public DoubleL10x10x3over4x1_1over2() { }
    }
}
