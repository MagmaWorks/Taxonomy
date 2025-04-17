namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x45 : SingletonAmericanBase<W16x45>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X45";
        public Length Height => new Length(16.10, LengthUnit.Inch);
        public Length Width => new Length(7.04, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public W16x45() { }
    }
}
