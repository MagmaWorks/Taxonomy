namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W44x335 : SingletonAmericanBase<W44x335>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W44X335";
        public Length Height => new Length(44.00, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.77, LengthUnit.Inch);
        public Length WebThickness => new Length(1.03, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W44x335() { }
    }
}
