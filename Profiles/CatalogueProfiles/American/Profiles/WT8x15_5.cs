namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x15_5 : SingletonAmericanBase<WT8x15_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X15.5";
        public Length Height => new Length(7.94, LengthUnit.Inch);
        public Length Width => new Length(5.53, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x15_5() { }
    }
}
