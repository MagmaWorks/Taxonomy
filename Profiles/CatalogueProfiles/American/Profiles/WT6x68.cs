namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x68 : SingletonAmericanBase<WT6x68>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X68";
        public Length Height => new Length(6.71, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x68() { }
    }
}
