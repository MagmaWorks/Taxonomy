namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x145_5 : SingletonAmericanBase<WT16_5x145_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X145.5";
        public Length Height => new Length(17.40, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.73, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.88, LengthUnit.Inch);

        public WT16_5x145_5() { }
    }
}
