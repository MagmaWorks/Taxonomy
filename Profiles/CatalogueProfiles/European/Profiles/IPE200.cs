namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE200 : SingletonEuropeanBase<IPE200>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 200";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPE200() { }
    }
}
