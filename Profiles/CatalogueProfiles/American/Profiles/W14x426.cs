namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x426 : SingletonAmericanBase<W14x426>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X426";
        public Length Height => new Length(18.70, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.04, LengthUnit.Inch);
        public Length WebThickness => new Length(1.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W14x426() { }
    }
}
