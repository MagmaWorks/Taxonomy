namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x215 : SingletonAmericanBase<W40x215>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X215";
        public Length Height => new Length(39.00, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W40x215() { }
    }
}
