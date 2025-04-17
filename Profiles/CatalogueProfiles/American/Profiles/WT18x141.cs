namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x141 : SingletonAmericanBase<WT18x141>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X141";
        public Length Height => new Length(18.60, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.08, LengthUnit.Inch);

        public WT18x141() { }
    }
}
