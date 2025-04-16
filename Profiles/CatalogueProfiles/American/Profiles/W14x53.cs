namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x53 : SingletonAmericanBase<W14x53>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X53";
        public Length Height => new Length(13.90, LengthUnit.Inch);
        public Length Width => new Length(8.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.66, LengthUnit.Inch);
        public Length WebThickness => new Length(0.37, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.815, LengthUnit.Inch);

        public W14x53() { }
    }
}
