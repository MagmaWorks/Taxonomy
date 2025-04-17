namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT8x50 : SingletonAmericanBase<WT8x50>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT8X50";
        public Length Height => new Length(8.49, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.1, LengthUnit.Inch);

        public WT8x50() { }
    }
}
