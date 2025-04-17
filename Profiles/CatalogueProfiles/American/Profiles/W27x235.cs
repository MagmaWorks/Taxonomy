namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x235 : SingletonAmericanBase<W27x235>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X235";
        public Length Height => new Length(28.70, LengthUnit.Inch);
        public Length Width => new Length(14.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.91, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W27x235() { }
    }
}
