namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x45 : SingletonAmericanBase<W12x45>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X45";
        public Length Height => new Length(12.10, LengthUnit.Inch);
        public Length Width => new Length(8.05, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.34, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.77, LengthUnit.Inch);

        public W12x45() { }
    }
}
