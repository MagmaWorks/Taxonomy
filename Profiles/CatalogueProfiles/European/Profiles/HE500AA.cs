namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE500AA : SingletonEuropeanBase<HE500AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 500 AA";
        public Length Height => new Length(472, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE500AA() { }
    }
}
