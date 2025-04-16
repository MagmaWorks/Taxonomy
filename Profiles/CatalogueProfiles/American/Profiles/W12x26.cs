namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x26 : SingletonAmericanBase<W12x26>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X26";
        public Length Height => new Length(12.20, LengthUnit.Inch);
        public Length Width => new Length(6.49, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.38, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public W12x26() { }
    }
}
