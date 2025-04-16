namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO200 : SingletonEuropeanBase<IPEO200>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 200";
        public Length Height => new Length(202, LengthUnit.Millimeter);
        public Length Width => new Length(102, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPEO200() { }
    }
}
