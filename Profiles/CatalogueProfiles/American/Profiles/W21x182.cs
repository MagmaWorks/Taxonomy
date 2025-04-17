namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x182 : SingletonAmericanBase<W21x182>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X182";
        public Length Height => new Length(22.70, LengthUnit.Inch);
        public Length Width => new Length(12.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.48, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W21x182() { }
    }
}
