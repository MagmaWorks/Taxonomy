namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE120 : SingletonEuropeanBase<UPE120>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 120";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(60, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public UPE120() { }
    }
}
