namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S18x54_7 : SingletonAmericanBase<S18x54_7>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S18X54.7";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.81, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.486, LengthUnit.Inch);
        public Length WebHeight => new Length(15.00, LengthUnit.Inch);

        public S18x54_7() { }
    }
}
