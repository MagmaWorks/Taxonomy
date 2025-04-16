namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB838x292x226 : SingletonEuropeanBase<UB838x292x226>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 838 × 292 × 226";
        public Length Height => new Length(850.9, LengthUnit.Millimeter);
        public Length Width => new Length(293.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UB838x292x226() { }
    }
}
