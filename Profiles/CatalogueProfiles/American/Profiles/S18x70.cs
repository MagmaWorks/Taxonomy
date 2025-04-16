namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S18x70 : SingletonAmericanBase<S18x70>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S18X70";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(6.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.81, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.486, LengthUnit.Inch);
        public Length WebHeight => new Length(15.00, LengthUnit.Inch);

        public S18x70() { }
    }
}
