namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE240M : SingletonEuropeanBase<HE240M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 240 M";
        public Length Height => new Length(270, LengthUnit.Millimeter);
        public Length Width => new Length(248, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public HE240M() { }
    }
}
