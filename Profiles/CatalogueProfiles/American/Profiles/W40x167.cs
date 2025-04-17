namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x167 : SingletonAmericanBase<W40x167>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X167";
        public Length Height => new Length(38.60, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.03, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W40x167() { }
    }
}
