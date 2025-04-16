namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x141 : SingletonAmericanBase<W33x141>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X141";
        public Length Height => new Length(33.30, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.96, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public W33x141() { }
    }
}
