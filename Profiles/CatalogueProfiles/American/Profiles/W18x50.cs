namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x50 : SingletonAmericanBase<W18x50>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X50";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(7.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.63, LengthUnit.Inch);

        public W18x50() { }
    }
}
