namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x13 : SingletonAmericanBase<WT8x13>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X13";
        public Length Height => new Length(7.85, LengthUnit.Inch);
        public Length Width => new Length(5.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x13() { }
    }
}
