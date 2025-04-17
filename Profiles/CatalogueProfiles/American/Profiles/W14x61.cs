namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x61 : SingletonAmericanBase<W14x61>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X61";
        public Length Height => new Length(13.90, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.81, LengthUnit.Inch);

        public W14x61() { }
    }
}
