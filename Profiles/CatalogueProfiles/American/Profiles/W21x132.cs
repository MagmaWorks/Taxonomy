namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x132 : SingletonAmericanBase<W21x132>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X132";
        public Length Height => new Length(21.80, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.04, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W21x132() { }
    }
}
