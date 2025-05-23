namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA100 : SingletonEuropeanBase<IPEA100>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 100";
        public Length Height => new Length(98, LengthUnit.Millimeter);
        public Length Width => new Length(55, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEA100() { }
    }
}
