namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x170 : SingletonAmericanBase<W12x170>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X170";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.83, LengthUnit.Inch);

        public W12x170() { }
    }
}
