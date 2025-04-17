namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA240 : SingletonEuropeanBase<IPEA240>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 240";
        public Length Height => new Length(237, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEA240() { }
    }
}
