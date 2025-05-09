namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC150x90x24 : SingletonEuropeanBase<PFC150x90x24>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 150 × 90 × 24";
        public Length Height => new Length(150, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC150x90x24() { }
    }
}
