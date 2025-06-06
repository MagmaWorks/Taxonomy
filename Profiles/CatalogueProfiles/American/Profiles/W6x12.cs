namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x12 : SingletonAmericanBase<W6x12>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X12";
        public Length Height => new Length(6.03, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.28, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.445, LengthUnit.Inch);

        public W6x12() { }
    }
}
