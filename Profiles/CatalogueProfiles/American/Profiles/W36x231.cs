namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W36x231 : SingletonAmericanBase<W36x231>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W36X231";
        public Length Height => new Length(36.50, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.76, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.18, LengthUnit.Inch);

        public W36x231() { }
    }
}
