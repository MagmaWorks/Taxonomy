namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x263 : SingletonAmericanBase<W33x263>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X263";
        public Length Height => new Length(34.50, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public W33x263() { }
    }
}
