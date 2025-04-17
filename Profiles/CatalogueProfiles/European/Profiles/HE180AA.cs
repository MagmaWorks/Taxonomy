namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180AA : SingletonEuropeanBase<HE180AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 180 AA";
        public Length Height => new Length(167, LengthUnit.Millimeter);
        public Length Width => new Length(180, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE180AA() { }
    }
}
