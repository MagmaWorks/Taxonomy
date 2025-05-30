namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x166 : SingletonAmericanBase<W21x166>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X166";
        public Length Height => new Length(22.50, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public W21x166() { }
    }
}
