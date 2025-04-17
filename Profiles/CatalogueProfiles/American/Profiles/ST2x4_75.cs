namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST2x4_75 : SingletonAmericanBase<ST2x4_75>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST2X4.75";
        public Length Height => new Length(2.00, LengthUnit.Inch);
        public Length Width => new Length(2.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.33, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.25, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.625, LengthUnit.Inch);

        public ST2x4_75() { }
    }
}
