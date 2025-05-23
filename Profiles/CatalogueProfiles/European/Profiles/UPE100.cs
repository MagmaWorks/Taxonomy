namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE100 : SingletonEuropeanBase<UPE100>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 100";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(55, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UPE100() { }
    }
}
