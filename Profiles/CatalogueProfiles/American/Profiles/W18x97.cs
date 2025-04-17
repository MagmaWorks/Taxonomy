namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x97 : SingletonAmericanBase<W18x97>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X97";
        public Length Height => new Length(18.60, LengthUnit.Inch);
        public Length Width => new Length(11.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.86, LengthUnit.Inch);

        public W18x97() { }
    }
}
