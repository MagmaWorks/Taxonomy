namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x57 : SingletonAmericanBase<W21x57>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X57";
        public Length Height => new Length(21.10, LengthUnit.Inch);
        public Length Width => new Length(6.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.605, LengthUnit.Inch);

        public W21x57() { }
    }
}
