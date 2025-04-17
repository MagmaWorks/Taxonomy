namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEV500 : SingletonEuropeanBase<IPEV500>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEV;
        public override string Label => "IPE V 500";
        public Length Height => new Length(514, LengthUnit.Millimeter);
        public Length Width => new Length(204, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEV500() { }
    }
}
