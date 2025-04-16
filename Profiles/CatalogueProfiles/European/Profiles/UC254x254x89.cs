namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC254x254x89 : SingletonEuropeanBase<UC254x254x89>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 254 × 254 × 89";
        public Length Height => new Length(260.3, LengthUnit.Millimeter);
        public Length Width => new Length(256.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UC254x254x89() { }
    }
}
