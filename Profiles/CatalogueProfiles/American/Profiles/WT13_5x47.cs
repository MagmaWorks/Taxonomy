namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x47 : SingletonAmericanBase<WT13_5x47>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X47";
        public Length Height => new Length(13.50, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.49, LengthUnit.Inch);
        public Length FilletRadius => new Length(12.16, LengthUnit.Inch);

        public WT13_5x47() { }
    }
}
