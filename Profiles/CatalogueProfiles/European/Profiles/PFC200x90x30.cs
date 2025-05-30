namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC200x90x30 : SingletonEuropeanBase<PFC200x90x30>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 200 × 90 × 30";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC200x90x30() { }
    }
}
