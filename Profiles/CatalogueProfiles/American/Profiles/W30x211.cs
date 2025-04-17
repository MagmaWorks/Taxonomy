namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x211 : SingletonAmericanBase<W30x211>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X211";
        public Length Height => new Length(30.90, LengthUnit.Inch);
        public Length Width => new Length(15.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.78, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W30x211() { }
    }
}
