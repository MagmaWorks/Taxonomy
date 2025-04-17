namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M10x9 : SingletonAmericanBase<M10x9>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M10X9";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(2.69, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.3, LengthUnit.Inch);

        public M10x9() { }
    }
}
