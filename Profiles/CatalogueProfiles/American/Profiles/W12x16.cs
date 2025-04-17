namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x16 : SingletonAmericanBase<W12x16>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X16";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.27, LengthUnit.Inch);
        public Length WebThickness => new Length(0.22, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.45, LengthUnit.Inch);

        public W12x16() { }
    }
}
