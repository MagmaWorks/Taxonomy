namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC300x90x41 : SingletonEuropeanBase<PFC300x90x41>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 300 × 90 × 41";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC300x90x41() { }
    }
}
