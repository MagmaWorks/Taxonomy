namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB533x210x109 : SingletonEuropeanBase<UB533x210x109>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 533 × 210 × 109";
        public Length Height => new Length(539.5, LengthUnit.Millimeter);
        public Length Width => new Length(210.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB533x210x109() { }
    }
}
