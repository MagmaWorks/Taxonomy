namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x257 : SingletonAmericanBase<W14x257>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X257";
        public Length Height => new Length(16.40, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W14x257() { }
    }
}
