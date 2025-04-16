namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x198 : SingletonEuropeanBase<UC305x305x198>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 305 × 305 × 198";
        public Length Height => new Length(339.9, LengthUnit.Millimeter);
        public Length Width => new Length(314.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(31.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x198() { }
    }
}
