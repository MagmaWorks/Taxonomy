namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class PFC100x50x10 : SingletonEuropeanBase<PFC100x50x10>, IChannelParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.PFC;
        public override string Label => "PFC 100 × 50 × 10";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(50, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public PFC100x50x10() { }
    }
}
