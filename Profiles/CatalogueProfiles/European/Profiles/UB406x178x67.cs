namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x178x67 : SingletonEuropeanBase<UB406x178x67>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 406 × 178 × 67";
        public Length Height => new Length(409.4, LengthUnit.Millimeter);
        public Length Width => new Length(178.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x178x67() { }
    }
}
