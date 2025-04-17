namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC305x305x97 : SingletonEuropeanBase<UC305x305x97>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 305 × 305 × 97";
        public Length Height => new Length(307.9, LengthUnit.Millimeter);
        public Length Width => new Length(305.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC305x305x97() { }
    }
}
