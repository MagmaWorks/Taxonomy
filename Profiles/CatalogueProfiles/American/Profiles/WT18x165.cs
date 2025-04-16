namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x165 : SingletonAmericanBase<WT18x165>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X165";
        public Length Height => new Length(18.80, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(16, LengthUnit.Inch);

        public WT18x165() { }
    }
}
