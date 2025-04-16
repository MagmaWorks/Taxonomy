namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x73_5 : SingletonAmericanBase<WT10_5x73_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X73.5";
        public Length Height => new Length(11.00, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.15, LengthUnit.Inch);
        public Length WebThickness => new Length(0.72, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.35, LengthUnit.Inch);

        public WT10_5x73_5() { }
    }
}
