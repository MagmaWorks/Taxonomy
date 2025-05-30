namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE240 : SingletonEuropeanBase<UPE240>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 240";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UPE240() { }
    }
}
