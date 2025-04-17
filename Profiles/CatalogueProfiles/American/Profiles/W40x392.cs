namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x392 : SingletonAmericanBase<W40x392>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X392";
        public Length Height => new Length(41.60, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.52, LengthUnit.Inch);
        public Length WebThickness => new Length(1.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W40x392() { }
    }
}
