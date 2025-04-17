namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x66 : SingletonAmericanBase<WT10_5x66>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X66";
        public Length Height => new Length(10.90, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.04, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.36, LengthUnit.Inch);

        public WT10_5x66() { }
    }
}
