namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x108_5 : SingletonAmericanBase<WT13_5x108_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X108.5";
        public Length Height => new Length(14.20, LengthUnit.Inch);
        public Length Width => new Length(14.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(11.91, LengthUnit.Inch);

        public WT13_5x108_5() { }
    }
}
