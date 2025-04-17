namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x76 : SingletonAmericanBase<W18x76>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X76";
        public Length Height => new Length(18.20, LengthUnit.Inch);
        public Length Width => new Length(11.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.845, LengthUnit.Inch);

        public W18x76() { }
    }
}
