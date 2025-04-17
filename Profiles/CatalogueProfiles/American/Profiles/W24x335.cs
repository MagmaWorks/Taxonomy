namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x335 : SingletonAmericanBase<W24x335>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X335";
        public Length Height => new Length(27.50, LengthUnit.Inch);
        public Length Width => new Length(13.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.48, LengthUnit.Inch);
        public Length WebThickness => new Length(1.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public W24x335() { }
    }
}
