namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE80 : SingletonEuropeanBase<UPE80>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 80";
        public Length Height => new Length(80, LengthUnit.Millimeter);
        public Length Width => new Length(50, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UPE80() { }
    }
}
