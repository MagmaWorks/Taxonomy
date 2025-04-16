namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x436_5 : SingletonAmericanBase<WT7x436_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X436.5";
        public Length Height => new Length(11.80, LengthUnit.Inch);
        public Length Width => new Length(18.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(5.51, LengthUnit.Inch);
        public Length WebThickness => new Length(3.94, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x436_5() { }
    }
}
