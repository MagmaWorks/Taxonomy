namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x39 : SingletonAmericanBase<W10x39>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X39";
        public Length Height => new Length(9.92, LengthUnit.Inch);
        public Length Width => new Length(7.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.65, LengthUnit.Inch);

        public W10x39() { }
    }
}
