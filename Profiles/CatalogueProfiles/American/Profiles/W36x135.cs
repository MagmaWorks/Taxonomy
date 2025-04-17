namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x135 : SingletonAmericanBase<W36x135>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X135";
        public Length Height => new Length(35.60, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.79, LengthUnit.Inch);
        public Length WebThickness => new Length(0.60, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W36x135() { }
    }
}
