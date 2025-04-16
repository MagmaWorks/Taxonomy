namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x247 : SingletonAmericanBase<W36x247>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X247";
        public Length Height => new Length(36.70, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.80, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W36x247() { }
    }
}
