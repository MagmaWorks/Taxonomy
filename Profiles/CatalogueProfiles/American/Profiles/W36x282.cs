namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x282 : SingletonAmericanBase<W36x282>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X282";
        public Length Height => new Length(37.10, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public W36x282() { }
    }
}
