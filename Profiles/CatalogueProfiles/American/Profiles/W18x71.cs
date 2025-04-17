namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x71 : SingletonAmericanBase<W18x71>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X71";
        public Length Height => new Length(18.50, LengthUnit.Inch);
        public Length Width => new Length(7.64, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.63, LengthUnit.Inch);

        public W18x71() { }
    }
}
