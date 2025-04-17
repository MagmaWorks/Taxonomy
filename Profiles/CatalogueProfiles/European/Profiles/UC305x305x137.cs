namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x137 : SingletonEuropeanBase<UC305x305x137>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 305 × 305 × 137";
        public Length Height => new Length(320.5, LengthUnit.Millimeter);
        public Length Width => new Length(309.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x137() { }
    }
}
