namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x311 : SingletonAmericanBase<W14x311>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X311";
        public Length Height => new Length(17.10, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.26, LengthUnit.Inch);
        public Length WebThickness => new Length(1.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W14x311() { }
    }
}
