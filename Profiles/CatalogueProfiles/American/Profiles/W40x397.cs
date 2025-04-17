namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x397 : SingletonAmericanBase<W40x397>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X397";
        public Length Height => new Length(41.00, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.20, LengthUnit.Inch);
        public Length WebThickness => new Length(1.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W40x397() { }
    }
}
