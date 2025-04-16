namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W44x368 : SingletonAmericanBase<W44x368>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W44X368";
        public Length Height => new Length(44.40, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.97, LengthUnit.Inch);
        public Length WebThickness => new Length(1.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W44x368() { }
    }
}
