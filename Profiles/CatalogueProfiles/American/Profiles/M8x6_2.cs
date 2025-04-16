namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M8x6_2 : SingletonAmericanBase<M8x6_2>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M8X6.2";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.185, LengthUnit.Inch);

        public M8x6_2() { }
    }
}
