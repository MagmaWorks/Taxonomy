namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x327 : SingletonAmericanBase<W40x327>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X327";
        public Length Height => new Length(40.80, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W40x327() { }
    }
}
