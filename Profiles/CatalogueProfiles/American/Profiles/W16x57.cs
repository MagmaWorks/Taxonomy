namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x57 : SingletonAmericanBase<W16x57>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X57";
        public Length Height => new Length(16.40, LengthUnit.Inch);
        public Length Width => new Length(7.12, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.72, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.665, LengthUnit.Inch);

        public W16x57() { }
    }
}
