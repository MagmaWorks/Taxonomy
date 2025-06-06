namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE900x466 : SingletonEuropeanBase<HE900x466>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 900 × 466";
        public Length Height => new Length(938, LengthUnit.Millimeter);
        public Length Width => new Length(312, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE900x466() { }
    }
}
