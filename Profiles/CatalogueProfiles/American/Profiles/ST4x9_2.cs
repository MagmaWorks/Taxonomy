namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST4x9_2 : SingletonAmericanBase<ST4x9_2>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST4X9.2";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(3, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.5, LengthUnit.Inch);

        public ST4x9_2() { }
    }
}
