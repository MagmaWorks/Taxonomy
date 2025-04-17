namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x262 : SingletonAmericanBase<W36x262>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X262";
        public Length Height => new Length(36.90, LengthUnit.Inch);
        public Length Width => new Length(16.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.84, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W36x262() { }
    }
}
