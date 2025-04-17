namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO360 : SingletonEuropeanBase<IPEO360>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 360";
        public Length Height => new Length(364, LengthUnit.Millimeter);
        public Length Width => new Length(172, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPEO360() { }
    }
}
