namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST2x3_85 : SingletonAmericanBase<ST2x3_85>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST2X3.85";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.66, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.25, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.625, LengthUnit.Inch);

        public ST2x3_85() { }
    }
}
