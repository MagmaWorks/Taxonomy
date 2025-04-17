namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST1_5x3_75 : SingletonAmericanBase<ST1_5x3_75>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST1.5X3.75";
        public Length Height => new Length(1.50, LengthUnit.Inch);
        public Length Width => new Length(2.51, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.87, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.435, LengthUnit.Inch);

        public ST1_5x3_75() { }
    }
}
