namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE100AA : SingletonEuropeanBase<HE100AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 100 AA";
        public Length Height => new Length(91, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE100AA() { }
    }
}
