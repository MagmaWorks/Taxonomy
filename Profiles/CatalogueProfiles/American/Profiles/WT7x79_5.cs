namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x79_5 : SingletonAmericanBase<WT7x79_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X79.5";
        public Length Height => new Length(7.49, LengthUnit.Inch);
        public Length Width => new Length(15.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x79_5() { }
    }
}
