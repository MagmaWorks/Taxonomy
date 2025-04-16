namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO450 : SingletonEuropeanBase<IPEO450>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 450";
        public Length Height => new Length(456, LengthUnit.Millimeter);
        public Length Width => new Length(192, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEO450() { }
    }
}
