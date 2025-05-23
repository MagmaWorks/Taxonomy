namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE260A : SingletonEuropeanBase<HE260A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 260 A";
        public Length Height => new Length(250, LengthUnit.Millimeter);
        public Length Width => new Length(260, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE260A() { }
    }
}
