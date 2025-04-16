namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x264_5 : SingletonAmericanBase<WT18x264_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X264.5";
        public Length Height => new Length(19.90, LengthUnit.Inch);
        public Length Width => new Length(17.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.91, LengthUnit.Inch);
        public Length WebThickness => new Length(1.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.04, LengthUnit.Inch);

        public WT18x264_5() { }
    }
}
