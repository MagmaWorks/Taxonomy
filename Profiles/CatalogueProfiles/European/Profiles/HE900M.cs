namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE900M : SingletonEuropeanBase<HE900M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 900 M";
        public Length Height => new Length(910, LengthUnit.Millimeter);
        public Length Width => new Length(302, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE900M() { }
    }
}
