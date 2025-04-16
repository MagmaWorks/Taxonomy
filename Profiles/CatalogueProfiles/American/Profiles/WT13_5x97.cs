namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x97 : SingletonAmericanBase<WT13_5x97>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X97";
        public Length Height => new Length(14.10, LengthUnit.Inch);
        public Length Width => new Length(14.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.34, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(11.97, LengthUnit.Inch);

        public WT13_5x97() { }
    }
}
