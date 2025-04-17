namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x38_5 : SingletonAmericanBase<WT8x38_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X38.5";
        public Length Height => new Length(8.26, LengthUnit.Inch);
        public Length Width => new Length(10.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.76, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x38_5() { }
    }
}
