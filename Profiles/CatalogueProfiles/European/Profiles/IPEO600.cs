namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO600 : SingletonEuropeanBase<IPEO600>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 600";
        public Length Height => new Length(610, LengthUnit.Millimeter);
        public Length Width => new Length(224, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEO600() { }
    }
}
