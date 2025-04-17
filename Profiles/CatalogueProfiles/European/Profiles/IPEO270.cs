namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO270 : SingletonEuropeanBase<IPEO270>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 270";
        public Length Height => new Length(274, LengthUnit.Millimeter);
        public Length Width => new Length(136, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEO270() { }
    }
}
