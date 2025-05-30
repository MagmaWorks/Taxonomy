namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT9x71_5 : SingletonAmericanBase<WT9x71_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT9X71.5";
        public Length Height => new Length(9.75, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.03, LengthUnit.Inch);

        public WT9x71_5() { }
    }
}
