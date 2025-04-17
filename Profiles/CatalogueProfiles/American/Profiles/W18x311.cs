namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x311 : SingletonAmericanBase<W18x311>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X311";
        public Length Height => new Length(22.30, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.74, LengthUnit.Inch);
        public Length WebThickness => new Length(1.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.8, LengthUnit.Inch);

        public W18x311() { }
    }
}
