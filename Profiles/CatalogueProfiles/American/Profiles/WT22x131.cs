namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x131 : SingletonAmericanBase<WT22x131>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X131";
        public Length Height => new Length(21.70, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(19.5, LengthUnit.Inch);

        public WT22x131() { }
    }
}
