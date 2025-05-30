namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE360 : SingletonEuropeanBase<IPE360>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 360";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(170, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPE360() { }
    }
}
