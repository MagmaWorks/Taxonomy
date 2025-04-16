namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x326 : SingletonAmericanBase<W30x326>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X326";
        public Length Height => new Length(32.40, LengthUnit.Inch);
        public Length Width => new Length(15.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.05, LengthUnit.Inch);
        public Length WebThickness => new Length(1.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.18, LengthUnit.Inch);

        public W30x326() { }
    }
}
