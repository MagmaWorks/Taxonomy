namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE280C : SingletonEuropeanBase<HE280C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 280 C";
        public Length Height => new Length(295, LengthUnit.Millimeter);
        public Length Width => new Length(284, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE280C() { }
    }
}
