namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x393 : SingletonEuropeanBase<UB1016x305x393>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 1016 × 305 × 393";
        public Length Height => new Length(1016, LengthUnit.Millimeter);
        public Length Width => new Length(303, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(43.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x393() { }
    }
}
