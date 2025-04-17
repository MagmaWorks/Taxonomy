namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA140 : SingletonEuropeanBase<IPEA140>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 140";
        public Length Height => new Length(137.4, LengthUnit.Millimeter);
        public Length Width => new Length(73, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEA140() { }
    }
}
