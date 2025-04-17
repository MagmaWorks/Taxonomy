namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA200 : SingletonEuropeanBase<IPEAA200>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 200";
        public Length Height => new Length(196.4, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPEAA200() { }
    }
}
