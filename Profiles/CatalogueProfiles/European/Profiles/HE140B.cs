namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE140B : SingletonEuropeanBase<HE140B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 140 B";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(140, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE140B() { }
    }
}
