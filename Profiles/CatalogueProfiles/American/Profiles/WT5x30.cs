namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT5x30 : SingletonAmericanBase<WT5x30>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT5X30";
        public Length Height => new Length(5.11, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.93, LengthUnit.Inch);

        public WT5x30() { }
    }
}
