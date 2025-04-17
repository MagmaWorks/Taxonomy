namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x31 : SingletonAmericanBase<WT12x31>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X31";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(7.04, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.81, LengthUnit.Inch);

        public WT12x31() { }
    }
}
