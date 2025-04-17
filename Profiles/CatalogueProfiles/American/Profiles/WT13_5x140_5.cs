namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT13_5x140_5 : SingletonAmericanBase<WT13_5x140_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT13.5X140.5";
        public Length Height => new Length(14.60, LengthUnit.Inch);
        public Length Width => new Length(14.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.93, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(11.88, LengthUnit.Inch);

        public WT13_5x140_5() { }
    }
}
