namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC125x65x15 : SingletonEuropeanBase<PFC125x65x15>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 125 × 65 × 15";
        public Length Height => new Length(125, LengthUnit.Millimeter);
        public Length Width => new Length(65, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public PFC125x65x15() { }
    }
}
