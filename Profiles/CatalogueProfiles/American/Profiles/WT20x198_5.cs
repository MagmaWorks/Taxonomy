namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x198_5 : SingletonAmericanBase<WT20x198_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X198.5";
        public Length Height => new Length(20.50, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.20, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.12, LengthUnit.Inch);

        public WT20x198_5() { }
    }
}
