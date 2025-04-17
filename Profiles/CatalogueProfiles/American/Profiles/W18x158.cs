namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x158 : SingletonAmericanBase<W18x158>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X158";
        public Length Height => new Length(19.70, LengthUnit.Inch);
        public Length Width => new Length(11.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.81, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.845, LengthUnit.Inch);

        public W18x158() { }
    }
}
