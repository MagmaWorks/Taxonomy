namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x99 : SingletonAmericanBase<W30x99>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X99";
        public Length Height => new Length(29.70, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.67, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W30x99() { }
    }
}
