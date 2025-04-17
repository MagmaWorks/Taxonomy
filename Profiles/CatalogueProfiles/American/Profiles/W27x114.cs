namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W27x114 : SingletonAmericanBase<W27x114>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W27X114";
        public Length Height => new Length(27.30, LengthUnit.Inch);
        public Length Width => new Length(10.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.93, LengthUnit.Inch);
        public Length WebThickness => new Length(0.57, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W27x114() { }
    }
}
