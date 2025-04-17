namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE260AA : SingletonEuropeanBase<HE260AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 260 AA";
        public Length Height => new Length(244, LengthUnit.Millimeter);
        public Length Width => new Length(260, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE260AA() { }
    }
}
