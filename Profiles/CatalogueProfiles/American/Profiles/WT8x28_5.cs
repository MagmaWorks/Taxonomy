namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x28_5 : SingletonAmericanBase<WT8x28_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X28.5";
        public Length Height => new Length(8.22, LengthUnit.Inch);
        public Length Width => new Length(7.12, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.72, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x28_5() { }
    }
}
