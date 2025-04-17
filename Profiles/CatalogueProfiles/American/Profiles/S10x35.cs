namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S10x35 : SingletonAmericanBase<S10x35>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S10X35";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(4.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.49, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.381, LengthUnit.Inch);
        public Length WebHeight => new Length(7.75, LengthUnit.Inch);

        public S10x35() { }
    }
}
