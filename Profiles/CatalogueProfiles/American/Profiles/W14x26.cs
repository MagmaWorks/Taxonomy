namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x26 : SingletonAmericanBase<W14x26>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X26";
        public Length Height => new Length(13.90, LengthUnit.Inch);
        public Length Width => new Length(5.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.62, LengthUnit.Inch);

        public W14x26() { }
    }
}
