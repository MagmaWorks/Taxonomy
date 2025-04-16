namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE120AA : SingletonEuropeanBase<HE120AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 120 AA";
        public Length Height => new Length(109, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE120AA() { }
    }
}
