namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x159 : SingletonAmericanBase<WT18x159>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X159";
        public Length Height => new Length(19.10, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.22, LengthUnit.Inch);

        public WT18x159() { }
    }
}
