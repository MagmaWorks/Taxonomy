namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPE270 : SingletonEuropeanBase<UPE270>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPE;
        public override string Label => "UPE 270";
        public Length Height => new Length(270, LengthUnit.Millimeter);
        public Length Width => new Length(95, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UPE270() { }
    }
}
