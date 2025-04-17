namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x36 : SingletonAmericanBase<W16x36>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X36";
        public Length Height => new Length(15.90, LengthUnit.Inch);
        public Length Width => new Length(6.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.6, LengthUnit.Inch);

        public W16x36() { }
    }
}
