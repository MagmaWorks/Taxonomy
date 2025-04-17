namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE220C : SingletonEuropeanBase<HE220C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 220 C";
        public Length Height => new Length(230, LengthUnit.Millimeter);
        public Length Width => new Length(223, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE220C() { }
    }
}
