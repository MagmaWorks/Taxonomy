namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x62 : SingletonAmericanBase<W24x62>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X62";
        public Length Height => new Length(23.70, LengthUnit.Inch);
        public Length Width => new Length(7.04, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.59, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.845, LengthUnit.Inch);

        public W24x62() { }
    }
}
