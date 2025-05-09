namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE160 : SingletonEuropeanBase<IPE160>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 160";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(82, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPE160() { }
    }
}
