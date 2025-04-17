namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x45 : SingletonAmericanBase<WT15x45>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X45";
        public Length Height => new Length(14.80, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.54, LengthUnit.Inch);

        public WT15x45() { }
    }
}
