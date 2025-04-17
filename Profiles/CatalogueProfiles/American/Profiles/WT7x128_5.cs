namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x128_5 : SingletonAmericanBase<WT7x128_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X128.5";
        public Length Height => new Length(8.19, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x128_5() { }
    }
}
