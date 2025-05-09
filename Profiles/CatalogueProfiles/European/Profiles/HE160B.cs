namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE160B : SingletonEuropeanBase<HE160B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 160 B";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(160, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE160B() { }
    }
}
