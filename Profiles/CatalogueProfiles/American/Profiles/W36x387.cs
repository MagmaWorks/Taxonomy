namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x387 : SingletonAmericanBase<W36x387>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X387";
        public Length Height => new Length(39.10, LengthUnit.Inch);
        public Length Width => new Length(12.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.56, LengthUnit.Inch);
        public Length WebThickness => new Length(1.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.23, LengthUnit.Inch);

        public W36x387() { }
    }
}
