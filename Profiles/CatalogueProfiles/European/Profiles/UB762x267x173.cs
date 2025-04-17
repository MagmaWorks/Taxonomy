namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB762x267x173 : SingletonEuropeanBase<UB762x267x173>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 762 × 267 × 173";
        public Length Height => new Length(762.2, LengthUnit.Millimeter);
        public Length Width => new Length(266.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public UB762x267x173() { }
    }
}
