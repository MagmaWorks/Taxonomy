namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x306 : SingletonAmericanBase<W24x306>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X306";
        public Length Height => new Length(27.10, LengthUnit.Inch);
        public Length Width => new Length(13.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.18, LengthUnit.Inch);

        public W24x306() { }
    }
}
