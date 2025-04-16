namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x132 : SingletonAmericanBase<W30x132>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X132";
        public Length Height => new Length(30.30, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(0.62, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W30x132() { }
    }
}
