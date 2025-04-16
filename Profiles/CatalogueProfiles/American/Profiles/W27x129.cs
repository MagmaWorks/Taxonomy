namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x129 : SingletonAmericanBase<W27x129>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X129";
        public Length Height => new Length(27.60, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.10, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public W27x129() { }
    }
}
