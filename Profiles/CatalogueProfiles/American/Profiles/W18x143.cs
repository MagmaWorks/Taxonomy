namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x143 : SingletonAmericanBase<W18x143>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X143";
        public Length Height => new Length(19.50, LengthUnit.Inch);
        public Length Width => new Length(11.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);

        public W18x143() { }
    }
}
