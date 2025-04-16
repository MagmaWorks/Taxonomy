namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x100 : SingletonAmericanBase<W16x100>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X100";
        public Length Height => new Length(17.00, LengthUnit.Inch);
        public Length Width => new Length(10.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.99, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.835, LengthUnit.Inch);

        public W16x100() { }
    }
}
