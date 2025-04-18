namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE160AA : SingletonEuropeanBase<HE160AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 160 AA";
        public Length Height => new Length(148, LengthUnit.Millimeter);
        public Length Width => new Length(160, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE160AA() { }
    }
}
