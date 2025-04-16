namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x404 : SingletonAmericanBase<WT7x404>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X404";
        public Length Height => new Length(11.40, LengthUnit.Inch);
        public Length Width => new Length(18.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(5.12, LengthUnit.Inch);
        public Length WebThickness => new Length(3.74, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.69, LengthUnit.Inch);

        public WT7x404() { }
    }
}
