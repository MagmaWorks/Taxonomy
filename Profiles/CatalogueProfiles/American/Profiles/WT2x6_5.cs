namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT2x6_5 : SingletonAmericanBase<WT2x6_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT2X6.5";
        public Length Height => new Length(2.08, LengthUnit.Inch);
        public Length Width => new Length(4.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.48, LengthUnit.Inch);

        public WT2x6_5() { }
    }
}
