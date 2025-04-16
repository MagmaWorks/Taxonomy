namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x112 : SingletonAmericanBase<W10x112>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X112";
        public Length Height => new Length(11.40, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.25, LengthUnit.Inch);
        public Length WebThickness => new Length(0.76, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.62, LengthUnit.Inch);

        public W10x112() { }
    }
}
