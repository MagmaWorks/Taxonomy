namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x67_5 : SingletonAmericanBase<WT18x67_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X67.5";
        public Length Height => new Length(17.80, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.79, LengthUnit.Inch);
        public Length WebThickness => new Length(0.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.26, LengthUnit.Inch);

        public WT18x67_5() { }
    }
}
