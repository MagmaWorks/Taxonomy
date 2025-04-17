namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA80 : SingletonEuropeanBase<IPEAA80>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEAA;
        public override string Label => "IPE AA 80";
        public Length Height => new Length(78, LengthUnit.Millimeter);
        public Length Width => new Length(46, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5, LengthUnit.Millimeter);

        public IPEAA80() { }
    }
}
