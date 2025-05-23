namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE140AA : SingletonEuropeanBase<HE140AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 140 AA";
        public Length Height => new Length(128, LengthUnit.Millimeter);
        public Length Width => new Length(140, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE140AA() { }
    }
}
