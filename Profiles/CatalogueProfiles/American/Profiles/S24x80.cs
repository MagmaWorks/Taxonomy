namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S24x80 : SingletonAmericanBase<S24x80>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S24X80";
        public Length Height => new Length(24.00, LengthUnit.Inch);
        public Length Width => new Length(7.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.88, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.528, LengthUnit.Inch);
        public Length WebHeight => new Length(20.50, LengthUnit.Inch);

        public S24x80() { }
    }
}
