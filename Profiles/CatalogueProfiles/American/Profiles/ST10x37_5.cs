namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST10x37_5 : SingletonAmericanBase<ST10x37_5>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST10X37.5";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(6.39, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.80, LengthUnit.Inch);
        public Length WebThickness => new Length(0.64, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.37, LengthUnit.Inch);
        public Length ToeRadius => new Length(4.185, LengthUnit.Inch);

        public ST10x37_5() { }
    }
}
