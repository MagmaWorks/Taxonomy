namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA300 : SingletonEuropeanBase<IPEA300>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 300";
        public Length Height => new Length(297, LengthUnit.Millimeter);
        public Length Width => new Length(150, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEA300() { }
    }
}
