namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S3x7_5 : SingletonAmericanBase<S3x7_5>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S3X7.5";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.51, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.365, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.219, LengthUnit.Inch);
        public Length WebHeight => new Length(1.75, LengthUnit.Inch);

        public S3x7_5() { }
    }
}
