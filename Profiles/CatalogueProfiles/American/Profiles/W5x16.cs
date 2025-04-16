namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W5x16 : SingletonAmericanBase<W5x16>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W5X16";
        public Length Height => new Length(5.01, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.24, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.32, LengthUnit.Inch);

        public W5x16() { }
    }
}
