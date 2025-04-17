namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x31 : SingletonAmericanBase<W8x31>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X31";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(8.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.605, LengthUnit.Inch);

        public W8x31() { }
    }
}
