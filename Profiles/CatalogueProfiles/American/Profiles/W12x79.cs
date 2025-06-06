namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x79 : SingletonAmericanBase<W12x79>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X79";
        public Length Height => new Length(12.40, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.74, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);

        public W12x79() { }
    }
}
