namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE280AA : SingletonEuropeanBase<HE280AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 280 AA";
        public Length Height => new Length(264, LengthUnit.Millimeter);
        public Length Width => new Length(280, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE280AA() { }
    }
}
