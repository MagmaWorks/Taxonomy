namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO300 : SingletonEuropeanBase<IPEO300>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 300";
        public Length Height => new Length(304, LengthUnit.Millimeter);
        public Length Width => new Length(152, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEO300() { }
    }
}
