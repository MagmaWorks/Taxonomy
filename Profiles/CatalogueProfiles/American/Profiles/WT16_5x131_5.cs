namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x131_5 : SingletonAmericanBase<WT16_5x131_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X131.5";
        public Length Height => new Length(17.30, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(14.94, LengthUnit.Inch);

        public WT16_5x131_5() { }
    }
}
