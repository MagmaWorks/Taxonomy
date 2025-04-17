namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x33_5 : SingletonAmericanBase<WT8x33_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X33.5";
        public Length Height => new Length(8.17, LengthUnit.Inch);
        public Length Width => new Length(10.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.67, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x33_5() { }
    }
}
