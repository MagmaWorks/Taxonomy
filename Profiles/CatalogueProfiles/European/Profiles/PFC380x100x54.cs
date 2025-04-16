namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC380x100x54 : SingletonEuropeanBase<PFC380x100x54>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 380 × 100 × 54";
        public Length Height => new Length(380, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public PFC380x100x54() { }
    }
}
