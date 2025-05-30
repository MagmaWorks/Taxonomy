namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE450AA : SingletonEuropeanBase<HE450AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 450 AA";
        public Length Height => new Length(425, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE450AA() { }
    }
}
