namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S15x42_9 : SingletonAmericanBase<S15x42_9>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S15X42.9";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(5.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.755, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.453, LengthUnit.Inch);
        public Length WebHeight => new Length(12.25, LengthUnit.Inch);

        public S15x42_9() { }
    }
}
