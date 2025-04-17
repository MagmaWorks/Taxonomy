namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x120 : SingletonAmericanBase<W12x120>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X120";
        public Length Height => new Length(13.10, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.11, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.835, LengthUnit.Inch);

        public W12x120() { }
    }
}
