namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W10x30 : SingletonAmericanBase<W10x30>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W10X30";
        public Length Height => new Length(10.50, LengthUnit.Inch);
        public Length Width => new Length(5.81, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.51, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.54, LengthUnit.Inch);

        public W10x30() { }
    }
}
