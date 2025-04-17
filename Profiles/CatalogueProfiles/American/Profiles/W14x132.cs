namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x132 : SingletonAmericanBase<W14x132>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X132";
        public Length Height => new Length(14.70, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.03, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W14x132() { }
    }
}
