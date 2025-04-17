namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x8_5 : SingletonAmericanBase<WT5x8_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X8.5";
        public Length Height => new Length(5.06, LengthUnit.Inch);
        public Length Width => new Length(4.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.43, LengthUnit.Inch);

        public WT5x8_5() { }
    }
}
