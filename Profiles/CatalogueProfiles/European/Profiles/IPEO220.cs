namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO220 : SingletonEuropeanBase<IPEO220>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 220";
        public Length Height => new Length(222, LengthUnit.Millimeter);
        public Length Width => new Length(112, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPEO220() { }
    }
}
