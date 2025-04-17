namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB203x133x30 : SingletonEuropeanBase<UB203x133x30>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 203 × 133 × 30";
        public Length Height => new Length(206.8, LengthUnit.Millimeter);
        public Length Width => new Length(133.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB203x133x30() { }
    }
}
