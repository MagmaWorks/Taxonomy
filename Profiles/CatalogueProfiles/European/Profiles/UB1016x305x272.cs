namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x272 : SingletonEuropeanBase<UB1016x305x272>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 1016 × 305 × 272";
        public Length Height => new Length(990, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(31, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x272() { }
    }
}
