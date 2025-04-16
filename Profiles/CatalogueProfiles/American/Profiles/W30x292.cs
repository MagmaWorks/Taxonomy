namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x292 : SingletonAmericanBase<W30x292>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X292";
        public Length Height => new Length(32.00, LengthUnit.Inch);
        public Length Width => new Length(15.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W30x292() { }
    }
}
