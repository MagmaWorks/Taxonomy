namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x193 : SingletonAmericanBase<W14x193>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X193";
        public Length Height => new Length(15.50, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.89, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.245, LengthUnit.Inch);

        public W14x193() { }
    }
}
