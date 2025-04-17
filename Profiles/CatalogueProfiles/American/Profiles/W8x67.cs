namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x67 : SingletonAmericanBase<W8x67>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X67";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(8.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.57, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);

        public W8x67() { }
    }
}
