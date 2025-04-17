namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE300 : SingletonEuropeanBase<IPE300>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 300";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(150, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPE300() { }
    }
}
