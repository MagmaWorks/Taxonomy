namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x100 : SingletonAmericanBase<W10x100>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X100";
        public Length Height => new Length(11.10, LengthUnit.Inch);
        public Length Width => new Length(10.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.12, LengthUnit.Inch);
        public Length WebThickness => new Length(0.68, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.66, LengthUnit.Inch);

        public W10x100() { }
    }
}
