namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x34 : SingletonAmericanBase<WT12x34>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X34";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(8.97, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(10.81, LengthUnit.Inch);

        public WT12x34() { }
    }
}
