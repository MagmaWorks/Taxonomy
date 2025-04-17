namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x426_5 : SingletonAmericanBase<WT18x426_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X426.5";
        public Length Height => new Length(21.60, LengthUnit.Inch);
        public Length Width => new Length(18.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.53, LengthUnit.Inch);
        public Length WebThickness => new Length(2.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.32, LengthUnit.Inch);

        public WT18x426_5() { }
    }
}
