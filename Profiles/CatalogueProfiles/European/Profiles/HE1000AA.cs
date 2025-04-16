namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000AA : SingletonEuropeanBase<HE1000AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 1000 AA";
        public Length Height => new Length(970, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000AA() { }
    }
}
