namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x19 : SingletonAmericanBase<W10x19>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X19";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(4.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.505, LengthUnit.Inch);

        public W10x19() { }
    }
}
