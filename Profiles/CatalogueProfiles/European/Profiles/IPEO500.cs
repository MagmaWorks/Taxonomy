namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO500 : SingletonEuropeanBase<IPEO500>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 500";
        public Length Height => new Length(506, LengthUnit.Millimeter);
        public Length Width => new Length(202, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEO500() { }
    }
}
