namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x593 : SingletonAmericanBase<W40x593>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X593";
        public Length Height => new Length(43.00, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.23, LengthUnit.Inch);
        public Length WebThickness => new Length(1.79, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W40x593() { }
    }
}
