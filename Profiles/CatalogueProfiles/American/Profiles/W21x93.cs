namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x93 : SingletonAmericanBase<W21x93>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X93";
        public Length Height => new Length(21.60, LengthUnit.Inch);
        public Length Width => new Length(8.42, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.93, LengthUnit.Inch);
        public Length WebThickness => new Length(0.58, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.65, LengthUnit.Inch);

        public W21x93() { }
    }
}
