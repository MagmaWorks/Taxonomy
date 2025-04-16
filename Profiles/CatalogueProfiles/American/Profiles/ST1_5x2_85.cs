namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST1_5x2_85 : SingletonAmericanBase<ST1_5x2_85>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST1.5X2.85";
        public Length Height => new Length(1.50, LengthUnit.Inch);
        public Length Width => new Length(2.33, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.87, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.435, LengthUnit.Inch);

        public ST1_5x2_85() { }
    }
}
