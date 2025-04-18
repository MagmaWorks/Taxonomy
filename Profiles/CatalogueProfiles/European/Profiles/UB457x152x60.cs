namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x152x60 : SingletonEuropeanBase<UB457x152x60>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 152 × 60";
        public Length Height => new Length(454.6, LengthUnit.Millimeter);
        public Length Width => new Length(152.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x152x60() { }
    }
}
