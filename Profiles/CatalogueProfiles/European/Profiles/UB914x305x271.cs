namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x271 : SingletonEuropeanBase<UB914x305x271>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 271";
        public Length Height => new Length(923, LengthUnit.Millimeter);
        public Length Width => new Length(307, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x271() { }
    }
}
