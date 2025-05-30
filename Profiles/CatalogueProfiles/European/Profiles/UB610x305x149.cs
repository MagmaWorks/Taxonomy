namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB610x305x149 : SingletonEuropeanBase<UB610x305x149>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 610 × 305 × 149";
        public Length Height => new Length(612.4, LengthUnit.Millimeter);
        public Length Width => new Length(304.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB610x305x149() { }
    }
}
