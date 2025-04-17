namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE500B : SingletonEuropeanBase<HE500B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 500 B";
        public Length Height => new Length(500, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(28, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE500B() { }
    }
}
