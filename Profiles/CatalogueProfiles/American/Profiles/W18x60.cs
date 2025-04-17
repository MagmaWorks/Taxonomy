namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x60 : SingletonAmericanBase<W18x60>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X60";
        public Length Height => new Length(18.20, LengthUnit.Inch);
        public Length Width => new Length(7.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.70, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.6, LengthUnit.Inch);

        public W18x60() { }
    }
}
