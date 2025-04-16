namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x474 : SingletonEuropeanBase<UB914x305x474>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 474";
        public Length Height => new Length(971, LengthUnit.Millimeter);
        public Length Width => new Length(316, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x474() { }
    }
}
