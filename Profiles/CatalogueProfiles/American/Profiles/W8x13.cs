namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x13 : SingletonAmericanBase<W8x13>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X13";
        public Length Height => new Length(7.99, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.445, LengthUnit.Inch);

        public W8x13() { }
    }
}
