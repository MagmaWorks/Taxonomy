namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE750x196 : SingletonEuropeanBase<IPE750x196>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 750 × 196";
        public Length Height => new Length(770, LengthUnit.Millimeter);
        public Length Width => new Length(268, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public IPE750x196() { }
    }
}
