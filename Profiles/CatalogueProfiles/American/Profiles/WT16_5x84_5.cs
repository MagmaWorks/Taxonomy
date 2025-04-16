namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x84_5 : SingletonAmericanBase<WT16_5x84_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X84.5";
        public Length Height => new Length(16.90, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.67, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.98, LengthUnit.Inch);

        public WT16_5x84_5() { }
    }
}
