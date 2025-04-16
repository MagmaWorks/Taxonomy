namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x275 : SingletonAmericanBase<WT7x275>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X275";
        public Length Height => new Length(10.10, LengthUnit.Inch);
        public Length Width => new Length(17.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.82, LengthUnit.Inch);
        public Length WebThickness => new Length(2.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.68, LengthUnit.Inch);

        public WT7x275() { }
    }
}
