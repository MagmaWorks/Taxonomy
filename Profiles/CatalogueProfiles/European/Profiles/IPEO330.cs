namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO330 : SingletonEuropeanBase<IPEO330>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 330";
        public Length Height => new Length(334, LengthUnit.Millimeter);
        public Length Width => new Length(162, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPEO330() { }
    }
}
