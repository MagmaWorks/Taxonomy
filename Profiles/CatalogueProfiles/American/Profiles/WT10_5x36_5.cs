namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT10_5x36_5 : SingletonAmericanBase<WT10_5x36_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT10.5X36.5";
        public Length Height => new Length(10.60, LengthUnit.Inch);
        public Length Width => new Length(8.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.74, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(9.36, LengthUnit.Inch);

        public WT10_5x36_5() { }
    }
}
