namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP356x368x109 : SingletonEuropeanBase<UBP356x368x109>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 356 × 368 × 109";
        public Length Height => new Length(346.4, LengthUnit.Millimeter);
        public Length Width => new Length(371, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP356x368x109() { }
    }
}
