namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x665 : SingletonAmericanBase<W14x665>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X665";
        public Length Height => new Length(21.60, LengthUnit.Inch);
        public Length Width => new Length(17.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.52, LengthUnit.Inch);
        public Length WebThickness => new Length(2.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W14x665() { }
    }
}
