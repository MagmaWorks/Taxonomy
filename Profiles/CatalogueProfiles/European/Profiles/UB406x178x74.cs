namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x178x74 : SingletonEuropeanBase<UB406x178x74>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 406 × 178 × 74";
        public Length Height => new Length(412.8, LengthUnit.Millimeter);
        public Length Width => new Length(179.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x178x74() { }
    }
}
