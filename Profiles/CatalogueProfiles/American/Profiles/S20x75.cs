namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S20x75 : SingletonAmericanBase<S20x75>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S20X75";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(6.39, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.80, LengthUnit.Inch);
        public Length WebThickness => new Length(0.64, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.495, LengthUnit.Inch);
        public Length WebHeight => new Length(16.75, LengthUnit.Inch);

        public S20x75() { }
    }
}
