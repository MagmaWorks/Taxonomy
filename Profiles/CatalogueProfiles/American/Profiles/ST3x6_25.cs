namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST3x6_25 : SingletonAmericanBase<ST3x6_25>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST3X6.25";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(3.33, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.19, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.095, LengthUnit.Inch);

        public ST3x6_25() { }
    }
}
