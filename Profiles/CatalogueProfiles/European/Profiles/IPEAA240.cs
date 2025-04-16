namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA240 : SingletonEuropeanBase<IPEAA240>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 240";
        public Length Height => new Length(236.4, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEAA240() { }
    }
}
