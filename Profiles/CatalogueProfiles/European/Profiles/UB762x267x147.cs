namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB762x267x147 : SingletonEuropeanBase<UB762x267x147>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 762 × 267 × 147";
        public Length Height => new Length(754, LengthUnit.Millimeter);
        public Length Width => new Length(265.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB762x267x147() { }
    }
}
