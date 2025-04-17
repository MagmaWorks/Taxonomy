namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x211 : SingletonAmericanBase<W18x211>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X211";
        public Length Height => new Length(20.70, LengthUnit.Inch);
        public Length Width => new Length(11.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.91, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.85, LengthUnit.Inch);

        public W18x211() { }
    }
}
