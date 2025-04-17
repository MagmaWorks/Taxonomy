namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x361 : SingletonAmericanBase<W36x361>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X361";
        public Length Height => new Length(38.00, LengthUnit.Inch);
        public Length Width => new Length(16.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.01, LengthUnit.Inch);
        public Length WebThickness => new Length(1.12, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W36x361() { }
    }
}
