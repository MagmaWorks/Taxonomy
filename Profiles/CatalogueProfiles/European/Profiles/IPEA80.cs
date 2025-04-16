namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA80 : SingletonEuropeanBase<IPEA80>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 80";
        public Length Height => new Length(78, LengthUnit.Millimeter);
        public Length Width => new Length(46, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5, LengthUnit.Millimeter);

        public IPEA80() { }
    }
}
