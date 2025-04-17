namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE260C : SingletonEuropeanBase<HE260C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 260 C";
        public Length Height => new Length(275, LengthUnit.Millimeter);
        public Length Width => new Length(264, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE260C() { }
    }
}
