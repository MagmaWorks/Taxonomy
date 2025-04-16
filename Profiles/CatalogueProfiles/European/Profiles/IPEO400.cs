namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO400 : SingletonEuropeanBase<IPEO400>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 400";
        public Length Height => new Length(404, LengthUnit.Millimeter);
        public Length Width => new Length(182, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEO400() { }
    }
}
