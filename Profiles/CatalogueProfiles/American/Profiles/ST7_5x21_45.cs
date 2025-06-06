namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST7_5x21_45 : SingletonAmericanBase<ST7_5x21_45>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST7.5X21.45";
        public Length Height => new Length(7.50, LengthUnit.Inch);
        public Length Width => new Length(5.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(6.12, LengthUnit.Inch);
        public Length ToeRadius => new Length(3.06, LengthUnit.Inch);

        public ST7_5x21_45() { }
    }
}
