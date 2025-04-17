namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W8x21 : SingletonAmericanBase<W8x21>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W8X21";
        public Length Height => new Length(8.28, LengthUnit.Inch);
        public Length Width => new Length(5.27, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.435, LengthUnit.Inch);

        public W8x21() { }
    }
}
