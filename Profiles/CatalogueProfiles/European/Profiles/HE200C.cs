namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE200C : SingletonEuropeanBase<HE200C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 200 C";
        public Length Height => new Length(210, LengthUnit.Millimeter);
        public Length Width => new Length(203, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE200C() { }
    }
}
