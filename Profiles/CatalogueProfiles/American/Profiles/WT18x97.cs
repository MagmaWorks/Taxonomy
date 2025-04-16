namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x97 : SingletonAmericanBase<WT18x97>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X97";
        public Length Height => new Length(18.20, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.77, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.19, LengthUnit.Inch);

        public WT18x97() { }
    }
}
