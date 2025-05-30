namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x122 : SingletonAmericanBase<W21x122>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X122";
        public Length Height => new Length(21.70, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.96, LengthUnit.Inch);
        public Length WebThickness => new Length(0.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W21x122() { }
    }
}
