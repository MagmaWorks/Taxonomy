namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEV600 : SingletonEuropeanBase<IPEV600>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEV;
        public override string Label => "IPE V 600";
        public Length Height => new Length(618, LengthUnit.Millimeter);
        public Length Width => new Length(228, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(28, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEV600() { }
    }
}
