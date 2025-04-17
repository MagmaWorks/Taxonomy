namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x305x179 : SingletonEuropeanBase<UB610x305x179>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 610 × 305 × 179";
        public Length Height => new Length(620.2, LengthUnit.Millimeter);
        public Length Width => new Length(307.1, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB610x305x179() { }
    }
}
