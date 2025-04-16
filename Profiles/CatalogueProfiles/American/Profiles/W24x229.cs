namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x229 : SingletonAmericanBase<W24x229>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X229";
        public Length Height => new Length(26.00, LengthUnit.Inch);
        public Length Width => new Length(13.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.73, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.21, LengthUnit.Inch);

        public W24x229() { }
    }
}
