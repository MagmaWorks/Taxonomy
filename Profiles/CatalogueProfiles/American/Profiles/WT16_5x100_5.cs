namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x100_5 : SingletonAmericanBase<WT16_5x100_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X100.5";
        public Length Height => new Length(16.80, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.15, LengthUnit.Inch);
        public Length WebThickness => new Length(0.72, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.86, LengthUnit.Inch);

        public WT16_5x100_5() { }
    }
}
