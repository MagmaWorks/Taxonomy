namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE500 : SingletonEuropeanBase<IPE500>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 500";
        public Length Height => new Length(500, LengthUnit.Millimeter);
        public Length Width => new Length(200, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPE500() { }
    }
}
