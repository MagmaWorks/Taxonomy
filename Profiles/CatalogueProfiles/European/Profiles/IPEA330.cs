namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA330 : SingletonEuropeanBase<IPEA330>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 330";
        public Length Height => new Length(327, LengthUnit.Millimeter);
        public Length Width => new Length(160, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPEA330() { }
    }
}
