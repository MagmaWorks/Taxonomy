namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO240 : SingletonEuropeanBase<IPEO240>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 240";
        public Length Height => new Length(242, LengthUnit.Millimeter);
        public Length Width => new Length(122, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEO240() { }
    }
}
