namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x47 : SingletonAmericanBase<WT12x47>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X47";
        public Length Height => new Length(12.20, LengthUnit.Inch);
        public Length Width => new Length(9.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.82, LengthUnit.Inch);

        public WT12x47() { }
    }
}
