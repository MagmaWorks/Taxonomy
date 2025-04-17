namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE160 : SingletonEuropeanBase<UPE160>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 160";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(70, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public UPE160() { }
    }
}
