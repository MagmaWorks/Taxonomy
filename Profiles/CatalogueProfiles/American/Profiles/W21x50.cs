namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x50 : SingletonAmericanBase<W21x50>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X50";
        public Length Height => new Length(20.80, LengthUnit.Inch);
        public Length Width => new Length(6.53, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.62, LengthUnit.Inch);

        public W21x50() { }
    }
}
