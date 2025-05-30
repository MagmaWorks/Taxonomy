namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x182 : SingletonAmericanBase<W36x182>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X182";
        public Length Height => new Length(36.30, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.73, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public W36x182() { }
    }
}
