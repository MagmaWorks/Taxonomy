namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x82 : SingletonAmericanBase<W14x82>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X82";
        public Length Height => new Length(14.30, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.86, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.805, LengthUnit.Inch);

        public W14x82() { }
    }
}
