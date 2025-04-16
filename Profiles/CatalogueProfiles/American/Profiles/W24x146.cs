namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x146 : SingletonAmericanBase<W24x146>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X146";
        public Length Height => new Length(24.70, LengthUnit.Inch);
        public Length Width => new Length(12.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.09, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W24x146() { }
    }
}
