namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE120B : SingletonEuropeanBase<HE120B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 120 B";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE120B() { }
    }
}
