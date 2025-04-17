namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W12x35 : SingletonAmericanBase<W12x35>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W12X35";
        public Length Height => new Length(12.50, LengthUnit.Inch);
        public Length Width => new Length(6.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.6, LengthUnit.Inch);

        public W12x35() { }
    }
}
