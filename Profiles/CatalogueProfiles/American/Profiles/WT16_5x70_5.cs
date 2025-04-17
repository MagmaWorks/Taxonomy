namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x70_5 : SingletonAmericanBase<WT16_5x70_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X70.5";
        public Length Height => new Length(16.70, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.96, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(15.04, LengthUnit.Inch);

        public WT16_5x70_5() { }
    }
}
