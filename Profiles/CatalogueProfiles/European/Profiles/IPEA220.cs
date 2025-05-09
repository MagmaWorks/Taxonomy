namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA220 : SingletonEuropeanBase<IPEA220>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 220";
        public Length Height => new Length(217, LengthUnit.Millimeter);
        public Length Width => new Length(110, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPEA220() { }
    }
}
