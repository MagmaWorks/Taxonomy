namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W6x20 : SingletonAmericanBase<W6x20>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W6X20";
        public Length Height => new Length(6.20, LengthUnit.Inch);
        public Length Width => new Length(6.02, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.37, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.43, LengthUnit.Inch);

        public W6x20() { }
    }
}
