namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x21_5 : SingletonAmericanBase<WT7x21_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X21.5";
        public Length Height => new Length(6.83, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.71, LengthUnit.Inch);

        public WT7x21_5() { }
    }
}
