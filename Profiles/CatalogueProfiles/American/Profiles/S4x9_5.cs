namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S4x9_5 : SingletonAmericanBase<S4x9_5>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S4X9.5";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.33, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.46, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.276, LengthUnit.Inch);
        public Length WebHeight => new Length(2.50, LengthUnit.Inch);

        public S4x9_5() { }
    }
}
