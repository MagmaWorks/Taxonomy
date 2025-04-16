namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x318 : SingletonAmericanBase<W36x318>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X318";
        public Length Height => new Length(38.20, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.22, LengthUnit.Inch);

        public W36x318() { }
    }
}
