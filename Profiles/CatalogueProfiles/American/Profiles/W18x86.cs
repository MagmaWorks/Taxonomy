namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x86 : SingletonAmericanBase<W18x86>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X86";
        public Length Height => new Length(18.40, LengthUnit.Inch);
        public Length Width => new Length(11.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.77, LengthUnit.Inch);
        public Length WebThickness => new Length(0.48, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.82, LengthUnit.Inch);

        public W18x86() { }
    }
}
