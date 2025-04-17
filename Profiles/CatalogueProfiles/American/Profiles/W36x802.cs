namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x802 : SingletonAmericanBase<W36x802>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X802";
        public Length Height => new Length(42.60, LengthUnit.Inch);
        public Length Width => new Length(18.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.29, LengthUnit.Inch);
        public Length WebThickness => new Length(2.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.81, LengthUnit.Inch);

        public W36x802() { }
    }
}
